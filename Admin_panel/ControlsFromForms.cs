﻿using Chat.Entities;
using Chat.Services;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
/*using static System.Windows.Forms.VisualStyles.VisualStyleElement;*/

namespace Chat.Admin_panel
{
    public partial class ControlsFromForms : Form
    {
        private PermissionsManagement permissionsManagement;

        private int idPermission;
        private string namePermission;
        public ControlsFromForms(int idPermission, string namePermission)
        {
            InitializeComponent();
            this.idPermission = idPermission;
            this.namePermission = namePermission;
        }

        public ControlsFromForms()
        {
            InitializeComponent();
            return;
        }

        private void newControlsFormList_Load()
        {
            ControlsFromFormsService controlsService = new ControlsFromFormsService();
            newControlsFormListView.Items.Clear();
            
            var newControlsList =  controlsService.GetNewContorlsFromPermission(idPermission);

            foreach (var newControl in newControlsList)
            {
                string[] newControlArray = new string[]
                {
                    newControl.id.ToString(),
                    newControl.description,
                    newControl.formName,
                    newControl.controlType,
                };

                ListViewItem listViewItem1 = new ListViewItem(newControlArray);
                newControlsFormListView.Items.Add(listViewItem1);
                AddingOptionsToFilter(newControlFilterComboBox, newControl.description);
            }         
        }

        private void usedControlsFormList_Load()
        {
            ControlsFromFormsService controlsService = new ControlsFromFormsService();
            usedControlsFormListView.Items.Clear();

            var usedControlsList = controlsService.GetUsedControlsFromPermission(idPermission);

            foreach (var usedControl in usedControlsList)
            {
                string[] usedControlArray = new string[]
                {
                    usedControl.id.ToString(),
                    usedControl.description,
                    usedControl.formName,
                    usedControl.controlType,
                };

                ListViewItem listViewItem1 = new ListViewItem(usedControlArray);
                usedControlsFormListView.Items.Add(listViewItem1);
                AddingOptionsToFilter(usedControlFilterComboBox, usedControl.description);
            }
        }

        public List<Control> getFormsControls(Control root)
        {
            List<Control> allAdminControls = new List<Control>();

            foreach (Control control in root.Controls)
            {
                if (control is Button || control is CheckBox || control is TextBox)
                    allAdminControls.Add(control);

                if (control.HasChildren)
                    allAdminControls.AddRange(getFormsControls(control));
            }

            return allAdminControls;
        }

        private void ControlsFromForms_Load(object sender, EventArgs e)
        {
            permissionsManagement = new PermissionsManagement(this);
            permissionsManagement.CheckingPermissions();

            newControlsFormList_Load();
            usedControlsFormList_Load();
            permissionNameTextBox.Text = namePermission;
        }

        public void movingItemsInLists(ListView fromListView, ListView toListView, bool onlySelected = true)
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
                            item.SubItems[2].Text,
                            item.SubItems[3].Text,
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
                        item.SubItems[2].Text,
                        item.SubItems[3].Text,
                    };
                    ListViewItem listView = new ListViewItem(dataSelected);
                    toListView.Items.Add(listView);
                    fromListView.Items.Remove(item);
                }
            }
        }

        //new controls > used controls
        private void rightArrowBtn_Click(object sender, EventArgs e)
        {
            movingItemsInLists(newControlsFormListView, usedControlsFormListView, true);
        }
        //new controls >> used controls
        private void dbRightArrowBtn_Click(object sender, EventArgs e)
        {
            movingItemsInLists(newControlsFormListView, usedControlsFormListView, false);
        }

        //used controls > new controls
        private void leftArrowBtn_Click(object sender, EventArgs e)
        {
            movingItemsInLists(usedControlsFormListView, newControlsFormListView, true);
        }
        //used controls >> new controls
        private void dbLeftArrowBtn_Click(object sender, EventArgs e)
        {
            movingItemsInLists(usedControlsFormListView, newControlsFormListView, false);
        }

        private void saveControlsFromPermissionBtn_Click(object sender, EventArgs e)
        {
            ControlsFromFormsService controlsService = new ControlsFromFormsService();
            /*InitializingEnviroment initializing = new InitializingEnviroment();*/
            Notification notification = new Notification();          

            controlsService.RemoveAllControlsFromPermission(idPermission);

            foreach (ListViewItem item in usedControlsFormListView.Items)
            {
                controlsService.SaveNewContorlsFromPermission(idPermission, Int32.Parse(item.Text));

            }
            
            Form form = new Form();
            string[] exe = new string[] { };

            notification.GetNotification("success", "The data has been saved!");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void backChangesControlsBtn_Click(object sender, EventArgs e)
        {
            newControlsFormList_Load();
            usedControlsFormList_Load();
        }

        private void AddingOptionsToFilter(ComboBox comboBox, string option)
        {
            if (!comboBox.Items.Contains("-"))
                comboBox.Items.Add("-");

            comboBox.Items.Add(option);
        }

        private void newControlFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVal = newControlFilterComboBox
                .SelectedItem
                .ToString();

            if (selectedVal == "-" || selectedVal == "") newControlsFormList_Load();
            else
            {
                newControlsFormList_Load();
                foreach (ListViewItem item in newControlsFormListView.Items)
                {
                    if (item.SubItems[1].Text != selectedVal)
                    {
                        item.Remove();
                    }
                }
            }
        }

        private void usedControlFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVal = usedControlFilterComboBox
                .SelectedItem
                .ToString();

            if (selectedVal == "-" || selectedVal == "") usedControlsFormList_Load();
            else
            {
                usedControlsFormList_Load();
                foreach (ListViewItem item in usedControlsFormListView.Items)
                {
                    if (item.SubItems[1].Text != selectedVal)
                    {
                        item.Remove();
                    }
                }
            }
        }

    }
}
