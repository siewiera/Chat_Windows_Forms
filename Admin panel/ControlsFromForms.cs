using Chat.Entities;
using Chat.Services;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chat.Admin_panel
{
    public partial class ControlsFromForms : Form
    {
        private Permissions permission = new Permissions(21, "User");

        List<Control> allControls = new List<Control>();

        private int idPermission;
        private string namePermission;
        public ControlsFromForms(int idPermission = 9, string namePermission= "creating_rooms")
        {
            InitializeComponent();
            this.idPermission = idPermission;
            this.namePermission = namePermission;
        }

        private void newControlsFormList_Load()
        {
            ControlsFromFormsService controlsService = new ControlsFromFormsService();
            
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
            }         
        }

        private void usedControlsFormList_Load()
        {
            ControlsFromFormsService controlsService = new ControlsFromFormsService();

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
            this.Close();
        }
    }
}
