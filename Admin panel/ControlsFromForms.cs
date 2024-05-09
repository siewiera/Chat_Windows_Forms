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
        public ControlsFromForms()
        {
            InitializeComponent();
        }

        private void newControlsFormList_Load()
        {
            
            

            foreach (Control control in allControls)
            {
                string[] newControls = new string[]
                {
                    control.Name,
                    control.AccessibleDescription,
                    control.GetType().Name,
                };

                ListViewItem listViewItem1 = new ListViewItem(newControls);
                newControlsFormListView.Items.Add(listViewItem1);
            }         
        }

        public List<Control> getFormsControls(Control root)
        {
            List<Control> allAdminControls = new List<Control>();

            string[] typeControls = new string[]
            {
                "Button",
                "TextBox",
                "CheckBox"
            };

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
        }

        //new controls > used controls
        private void rightArrowBtn_Click(object sender, EventArgs e)
        {
            permission.movingItemsInLists(newControlsFormListView, usedControlsFormListView, true);
        }
        //new controls >> used controls
        private void dbRightArrowBtn_Click(object sender, EventArgs e)
        {
            permission.movingItemsInLists(newControlsFormListView, usedControlsFormListView, false);
        }

        //used controls > new controls
        private void leftArrowBtn_Click(object sender, EventArgs e)
        {
            permission.movingItemsInLists(usedControlsFormListView, newControlsFormListView, true);
        }
        //used controls >> new controls
        private void dbLeftArrowBtn_Click(object sender, EventArgs e)
        {
            permission.movingItemsInLists(usedControlsFormListView, newControlsFormListView, false);
        }

    }
}
