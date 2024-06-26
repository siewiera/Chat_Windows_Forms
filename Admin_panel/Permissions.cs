﻿using Chat.Admin_panel;
using Chat.Entities;
using Chat.Properties;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chat
{
    public partial class Permissions : Form
    {
        private AdminChatDashboardService adminChatDashboardService = new AdminChatDashboardService();
        private PermissionsManagement permissionsManagement;
        int idRole;
        string nameRole;

        public Permissions(int idRole, string nameRole)
        {
            InitializeComponent();
            this.idRole = idRole;
            this.nameRole = nameRole;

        }

        public Permissions()
        {
            InitializeComponent();
            return;
        }

        private void permissions_Load(object sender, EventArgs e)
        {
            permissionsManagement = new PermissionsManagement(this);
            permissionsManagement.CheckingPermissions();

            nameRoleLabel.Text = nameRole;
            usedPermissionsList_Load();
            newPermissionsList_Load();
            addActionToButton(sender, e);

            AddOptionsToUsedPermissionsFilterBox();
            AddOptionsToNewPermissionsFilterBox();
            

            ComponentResourceManager resources = new ComponentResourceManager(typeof(Permissions));
            savePermissionBtn.Image = ((Image)(resources.GetObject("savePermissionBtn.Image")));
            backChangesBtn.Image = ((Image)(resources.GetObject("backChangesBtn.Image")));
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void movingItemsInLists(System.Windows.Forms.ListView fromListView, 
            System.Windows.Forms.ListView toListView, bool onlySelected = true)
        {
            string[] dataSelected;
            foreach (ListViewItem item in fromListView.Items)
            {
                if (onlySelected)
                {
                    if (item.Selected)
                    {
                        dataSelected = new string[]
                        {
                            item.Text,
                            item.SubItems[1].Text,
                        };
                        ListViewItem listView = new ListViewItem(dataSelected);
                        toListView.Items.Add(listView);
                        fromListView.Items.Remove(item);
                    }
                }
                else
                {
                    dataSelected = new string[]
                    {
                        item.Text,
                        item.SubItems[1].Text,
                    };
                    ListViewItem listView = new ListViewItem(dataSelected);
                    toListView.Items.Add(listView);
                    fromListView.Items.Remove(item);
                }                
            }           
        }

        private void rightArrowBtn_Click(object sender, EventArgs e)
        {           
            movingItemsInLists(newPermissionsList, usedPermissionsList, true);
            AddOptionsToNewPermissionsFilterBox();
            AddOptionsToUsedPermissionsFilterBox();
        }

        private void dbRightArrowBtn_Click(object sender, EventArgs e)
        {                      
            movingItemsInLists(newPermissionsList, usedPermissionsList, false);
            newPermissionsFilterBox.Text = "-";
            FilteringTableNewPermissions();
            AddOptionsToNewPermissionsFilterBox();
            AddOptionsToUsedPermissionsFilterBox();
        }


        private void leftArrowBtn_Click(object sender, EventArgs e)
        {
            movingItemsInLists(usedPermissionsList, newPermissionsList, true);
            AddOptionsToNewPermissionsFilterBox();
            AddOptionsToUsedPermissionsFilterBox();
        }
        private void dbLeftArrowBtn_Click(object sender, EventArgs e)
        {                    
            movingItemsInLists(usedPermissionsList, newPermissionsList, false);
            usedPermissionsFilterBox.Text = "-";
            FilteringTableUsedPermissions();
            AddOptionsToNewPermissionsFilterBox();
            AddOptionsToUsedPermissionsFilterBox();
        }

        private void usedPermissionsList_Load(bool checkNewPermissionsList = false)
        {           
            usedPermissionsList.Items.Clear();
            if (checkNewPermissionsList)
            {
                var permissions = adminChatDashboardService
                .GetAllPermissions();

                var newPermissions = newPermissionsList.Items;
                foreach (var permission in permissions)
                {
                    bool itemExists = false;
                    if (permissions.Count() > 0)
                    {
                        foreach (ListViewItem item in newPermissions)
                        {
                            if (item.Text == permission.Id.ToString())
                            {
                                itemExists = true;
                            }
                        }
                        if (!itemExists)
                        {
                            string[] usedPermissions = new string[]
                            {
                                permission.Id.ToString(),
                                permission.Name.ToString()
                            };

                            ListViewItem listViewItem = new ListViewItem(usedPermissions);
                            usedPermissionsList.Items.Add(listViewItem);
                        }
                    }
                }
            }
            else
            {
                var permissions = adminChatDashboardService
                .GetAllUsedPermissions()
                .Where(s => s.idRole == idRole);

                foreach (var permission in permissions)
                {
                    if (permissions.Count() > 0)
                    {
                        string[] usedPermission = new string[]
                        {
                            permission.idPermission.ToString(),
                            permission.namePermission.ToString()
                        };

                        ListViewItem listViewItem = new ListViewItem(usedPermission);
                        usedPermissionsList.Items.Add(listViewItem);
                    }
                }
            }          
        }

        private void newPermissionsList_Load()
        {
            var permissions = adminChatDashboardService
                .GetAllPermissions();

            var usedPermissions = usedPermissionsList.Items;

            newPermissionsList.Items.Clear();

            foreach (var permission in permissions)
            {
                bool itemExists = false;
                if (permissions.Count() > 0)
                {
                    foreach (ListViewItem item in usedPermissions)
                    {
                        if (item.Text == permission.Id.ToString())
                        {
                            itemExists = true;
                        }
                    }
                    if (!itemExists) 
                    {
                        string[] newPermissions = new string[]
                        {
                        permission.Id.ToString(),
                        permission.Name.ToString()
                        };

                        ListViewItem listViewItem = new ListViewItem(newPermissions);
                        newPermissionsList.Items.Add(listViewItem);
                    }
                }               
            }
        }

        private void stylingButtonOnClick(object sender, EventArgs e, System.Windows.Forms.Button button, bool backColor = true)
        {
            if (backColor) 
            {
                button.FlatAppearance.BorderColor = Color.Gold;
                button.FlatAppearance.BorderSize = 1;
            }
            else 
            {
                button.FlatAppearance.BorderColor = Color.White;
                button.FlatAppearance.BorderSize = 2;
            }           
        }

        private void addActionToButton(object sender, EventArgs e)
        {
            rightArrowBtn.MouseDown += (s, args) => stylingButtonOnClick(sender, e, rightArrowBtn, false);
            rightArrowBtn.MouseUp += (s, args) => stylingButtonOnClick(sender, e, rightArrowBtn, true);

            dbRightArrowBtn.MouseDown += (s, args) => stylingButtonOnClick(sender, e, dbRightArrowBtn, false);
            dbRightArrowBtn.MouseUp += (s, args) => stylingButtonOnClick(sender, e, dbRightArrowBtn, true);

            leftArrowBtn.MouseDown += (s, args) => stylingButtonOnClick(sender, e, leftArrowBtn, false);
            leftArrowBtn.MouseUp += (s, args) => stylingButtonOnClick(sender, e, leftArrowBtn, true);

            dbLeftArrowBtn.MouseDown += (s, args) => stylingButtonOnClick(sender, e, dbLeftArrowBtn, false);
            dbLeftArrowBtn.MouseUp += (s, args) => stylingButtonOnClick(sender, e, dbLeftArrowBtn, true);
        }

        private void savePermissionBtn_Click(object sender, EventArgs e)
        {
            PermissionsService permissionsService = new PermissionsService();
            permissionsService.removeOldPermissions(idRole);

            foreach (ListViewItem item in usedPermissionsList.Items)
            {
                permissionsService.saveNewPermissions(idRole, Int32.Parse(item.Text));
                
            }

            Notification notification = new Notification();
            bool check = notification.GetNotification("Success", "Changes saved correctly!", false);
            if (check) this.Close();
        }

        private void backChangesBtn_Click(object sender, EventArgs e)
        {
            usedPermissionsList_Load();
            newPermissionsList_Load();
        }

        private void AddOptionsToUsedPermissionsFilterBox()
        {
            usedPermissionsFilterBox.Items.Clear();
            usedPermissionsFilterBox.ForeColor = Color.Gold;
            usedPermissionsFilterBox.Items.Add("-");
            foreach (ListViewItem item in usedPermissionsList.Items)
            {
                usedPermissionsFilterBox.Items.Add(item.SubItems[1].Text);
            }
        }

        private void FilteringTableUsedPermissions()
        {
            string selectedVal = usedPermissionsFilterBox
                .SelectedItem
                .ToString();

            if (selectedVal == "-" || selectedVal == "") usedPermissionsList_Load(true);
            else
            {
                usedPermissionsList_Load(true);
                foreach (ListViewItem item in usedPermissionsList.Items)
                {
                    if (item.SubItems[1].Text != selectedVal)
                    {
                        item.Remove();
                    }
                }
            }
        }


        private void AddOptionsToNewPermissionsFilterBox()
        {
            newPermissionsFilterBox.Items.Clear();
            newPermissionsFilterBox.ForeColor = Color.Gold;
            newPermissionsFilterBox.Items.Add("-");
            foreach (ListViewItem item in newPermissionsList.Items)
            {
                newPermissionsFilterBox.Items.Add(item.SubItems[1].Text);
            }
        }

        private void FilteringTableNewPermissions()
        {
            string selectedVal = newPermissionsFilterBox
                .SelectedItem
                .ToString();

            if (selectedVal == "-" || selectedVal == "") newPermissionsList_Load();
            else
            {
                newPermissionsList_Load();
                foreach (ListViewItem item in newPermissionsList.Items)
                {
                    if (item.SubItems[1].Text != selectedVal)
                    {
                        item.Remove();
                    }
                }
            }
        }

        private void newPermissionsFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilteringTableNewPermissions();
        }

        private void usedPermissionsFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilteringTableUsedPermissions();
        }

        private void addControlsBtn_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();

            int idPermission;
            string namePermission;
            if (newPermissionsList.SelectedItems.Count <= 0)
            {
                if (usedPermissionsList.SelectedItems.Count <= 0)
                {
                    notification.GetNotification("Error", "Select the role name to remove!");
                    return;
                }
                else
                {
                    idPermission = Int32.Parse(usedPermissionsList.SelectedItems[0].Text);
                    namePermission = usedPermissionsList.SelectedItems[0].SubItems[1].Text;
                }              
            }
            else 
            {
                idPermission = Int32.Parse(newPermissionsList.SelectedItems[0].Text);
                namePermission = newPermissionsList.SelectedItems[0].SubItems[1].Text;
            }
            

            ControlsFromForms controlsForms = new ControlsFromForms(idPermission, namePermission);
            InitializingEnviroment initializing = new InitializingEnviroment();
            Form form = new Form();
            string[] exe = new string[] { };

            initializing.LoadInitData(form, controlsForms, exe);

        }
    }
}
