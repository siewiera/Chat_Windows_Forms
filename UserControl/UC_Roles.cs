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

namespace Chat
{
    public partial class UC_Roles : UserControl
    {
        private AdminChatDashboardService adminChatDashboardService = new AdminChatDashboardService();
        private UC_RolesService rolesService = new UC_RolesService();
        private Notification notification = new Notification();
        public UC_Roles()
        {
            InitializeComponent();
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

        public void GetAllPermissionFromRole(object sender, EventArgs e)
        {
            int id = Int32.Parse(rolesList.SelectedItems[0].Text);
            var permissions = adminChatDashboardService
                .GetAllPermission()
                .Where(s => s.idRole == id);

            rolesListBox.Items.Clear();
            rolesListBox.Font = new Font("Comic Sans MS", 15, FontStyle.Italic);


            foreach (var permission in permissions)
            {
               /* Console.WriteLine(permission.v);*/
                if (permissions.Count() == 0) 
                {
                    rolesListBox.Items.Add("No permissions");
                    rolesListBox.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);
                    /*rolesListBox.*/
                }
                else rolesListBox.Items.Add(permission.namePermission);
            }         
        }

        private void AddPermissionBtn_Click(object sender, EventArgs e)
        {
            
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
            bool check = notification.GetNotification("warning", "test", true);
            Console.WriteLine(check);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notification.GetNotification("error", "test", true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notification.GetNotification("warning", "test", true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            notification.GetNotification("info", "test", true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            notification.GetNotification("success", "test", true);
        }
    }
}
