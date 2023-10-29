using Chat.Entities;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Chat.Services.SettingsAccountService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Chat
{
    public partial class UC_Roles : UserControl
    {
        private AdminChatDashboardService adminChatDashboardService = new AdminChatDashboardService();
        private UC_RolesService rolesService = new UC_RolesService();
        
        public UC_Roles()
        {
            InitializeComponent();
        }

        private void UC_Roles_Load(object sender, EventArgs e)
        {
            AddOptionsToRoleFilterBox();

            rolesList.Columns.Add("Id", -2, HorizontalAlignment.Left);
            rolesList.Columns.Add("Name", 400, HorizontalAlignment.Left);

            rolesList.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);

            LoadDataIntoTableRole();

            rolesList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);

            rolesList.ItemActivate += new EventHandler(GetAllPermissionFromRole);
            rolesList.ItemActivate += new EventHandler(rolesList_SelectedIndexChanged);
        }

        private void AddOptionsToRoleFilterBox()
        {
            rolesFilterBox.Items.Clear();
            var roles = adminChatDashboardService.GetAllRoles();
            string option;
            rolesFilterBox.Items.Add("-");
            foreach (var role in roles)
            {
                option = role.Name;
                rolesFilterBox.Items.Add(option);
            }
        }
        private void LoadDataIntoTableRole(int id = -1)
        {
            var roles = adminChatDashboardService.GetAllRoles();
            if (id > 0) roles = adminChatDashboardService.GetAllRoles().Where(e => e.Id == id);
            foreach (var role in roles)
            {
                string[] roles_data = new string[]
                {
                    role.Id.ToString(),
                    role.Name,
                };

                ListViewItem list = new ListViewItem(roles_data);
                list.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);

                if (role.Name == "Chat_Admin") list.ForeColor = Color.LightGreen;
                else if (role.Name == "Master_Admin") list.ForeColor = Color.YellowGreen;
                else list.ForeColor = Color.WhiteSmoke;

                rolesList.Items.Add(list);
            }
        }

        private void ClearListRole()
        {
            rolesList.Items.Clear();
        }

        public void RolesTableReload()
        {
            ClearListRole();
            LoadDataIntoTableRole();
            AddOptionsToRoleFilterBox();
        }

        private void FilteringTableRoles()
        {
            string selectedVal = rolesFilterBox
                .SelectedItem
                .ToString();

            ClearListRole();
            if (selectedVal == "-" || selectedVal == "") LoadDataIntoTableRole();
            else
            {
                int selectedRoleId = adminChatDashboardService
                    .GetAllRoles()
                    .Where(e => e.Name == selectedVal)
                    .First()
                    .Id;

                LoadDataIntoTableRole(selectedRoleId);
            }
        }

        private void rolesFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilteringTableRoles();          
        }

        private void rolesFilterIcon_Click(object sender, EventArgs e)
        {
            rolesFilterBox.SelectedItem = "-";
            RolesTableReload();
        }


        public void GetAllPermissionFromRole(object sender, EventArgs e)
        {
            int id = Int32.Parse(rolesList.SelectedItems[0].Text);
            var permissions = adminChatDashboardService
                .GetAllUsedPermissions()
                .Where(s => s.idRole == id);

            rolesListBox.Items.Clear();
            rolesListBox.Font = new Font("Comic Sans MS", 15, FontStyle.Italic);


            foreach (var permission in permissions)
            {
                if (permissions.Count() == 0) 
                {
                    rolesListBox.Items.Add("No permissions");
                    rolesListBox.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);
                }
                else rolesListBox.Items.Add(permission.namePermission);
            }         
        }

        private void AddPermissionBtn_Click(object sender, EventArgs e)
        {
            if (rolesList.SelectedItems.Count <= 0)
            {
                Notification notification = new Notification();
                notification.GetNotification("Error", "Select a role name to grant permissions!");
                return;
            }
            int idRole = Int32.Parse(rolesList.SelectedItems[0].Text);
            string nameRole = rolesList.SelectedItems[0].SubItems[1].Text;
            Permissions permissions = new Permissions(idRole, nameRole);
            permissions.Show();
        }

        private void AddRoleBtn_Click(object sender, EventArgs e)
        {
            string nameRole = rolesNameBox.Text;
            rolesService.addingRole(nameRole);
            RolesTableReload();
            rolesNameBox.Text = "";
        }

        private void editRoleBtn_Click(object sender, EventArgs e)
        {
            if (editPanel.Visible) editPanel.Hide();
            else editPanel.Show();
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            string newRoleName = rolesEditNameBox.Text;           
            if (rolesList.SelectedItems.Count <= 0)
            {
                Notification notification = new Notification();
                notification.GetNotification("Error", "Select the role name to edit!");
                return;
            }
            string idRole = rolesList.SelectedItems[0].Text;  
            rolesService.EditNameRole(Int32.Parse(idRole), newRoleName);
            RolesTableReload();
        }

        private void rolesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oldNameRole = rolesList.SelectedItems[0].SubItems[1].Text;
            rolesEditNameBox.Text = oldNameRole;
        }

        private void removeRoleBtn_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            if (rolesList.SelectedItems.Count <= 0)
            {
                notification.GetNotification("Error", "Select the role name to remove!");
                return;
            }
   
            string nameRole = rolesList.SelectedItems[0].SubItems[1].Text;

            bool check = notification.GetNotification("warning", $"Are you sure you want to delete the roles {nameRole}?", true);
            if (check) 
            {
                string idRole = rolesList.SelectedItems[0].Text;
                rolesService.RemoveNameRole(Int32.Parse(idRole));
                RolesTableReload();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            bool check = notification.GetNotification("error", "test", false);
            Console.WriteLine(check);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            bool check = notification.GetNotification("warning", "test", false);
            Console.WriteLine(check);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            bool check = notification.GetNotification("info", "test", false);
            Console.WriteLine(check);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            bool check = notification.GetNotification("success", "test", false);
            Console.WriteLine(check);
        }
    }
}
