using Chat.Entities;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Chat
{
    public partial class Permissions : Form
    {
        private AdminChatDashboardService adminChatDashboardService = new AdminChatDashboardService();
        int idRole;
        string nameRole;

        public Permissions(int idRole, string nameRole)
        {
            InitializeComponent();
            this.idRole = idRole;
            this.nameRole = nameRole;

        }

        private void permissions_Load(object sender, EventArgs e)
        {
            nameRoleLabel.Text = nameRole;
            usedPermissionsList_Load();
            newPermissionsList_Load();
            addActionToButton(sender, e);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void movingItemsInLists(ListView fromListView, ListView toListView, bool onlySelected = true)
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
            /* string[] dataSelected;
             foreach (ListViewItem item in newPermissionsList.Items)
             {
                 if (item.Selected)
                 {
                     dataSelected = new string[]
                     {
                         item.Text,
                         item.SubItems[1].Text,
                     };
                     ListViewItem usedPermissions = new ListViewItem(dataSelected);
                     usedPermissionsList.Items.Add(usedPermissions);
                     newPermissionsList.Items.Remove(item);
                 }
             }*/
            movingItemsInLists(newPermissionsList, usedPermissionsList, true);
        }

        private void dbRightArrowBtn_Click(object sender, EventArgs e)
        {
            movingItemsInLists(newPermissionsList, usedPermissionsList, false);
        }


        private void leftArrowBtn_Click(object sender, EventArgs e)
        {
            movingItemsInLists(usedPermissionsList, newPermissionsList, true);
        }
        private void dbLeftArrowBtn_Click(object sender, EventArgs e)
        {
            movingItemsInLists(usedPermissionsList, newPermissionsList, false);
        }

        private void usedPermissionsList_Load()
        {
            var permissions = adminChatDashboardService
                .GetAllUsedPermissions()
                .Where(s => s.idRole == idRole);

            usedPermissionsList.Items.Clear();

            foreach (var permission in permissions)
            {
                if (permissions.Count() > 0)
                {
                    usedPermissionsList.Items.Add(permission.namePermission);
                }
            }
        }

        private void newPermissionsList_Load()
        {
            var permissions = adminChatDashboardService
                .GetAllPermissions();

            /*string x = usedPermissionsList.Items[0].Name;

            Console.WriteLine(x);*/

            newPermissionsList.Items.Clear();

            foreach (var permission in permissions)
            {
                if (permissions.Count() > 0)
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

        private void stylingButtonOnClick(object sender, EventArgs e, Button button, bool backColor = true)
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
    }
}
