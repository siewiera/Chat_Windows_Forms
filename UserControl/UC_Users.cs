using Chat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class UC_Users : UserControl
    {
        private AdminChatDashboardService adminChatDashboardService = new AdminChatDashboardService();

        public UC_Users()
        {
            InitializeComponent();
        }

        public void settingsUserAccount(object sender, EventArgs e)
        {
            string id = usersList.SelectedItems[0].Text;
            SettingsAccount settings = new SettingsAccount(Int32.Parse(id), this);
            settings.Show();
        }

        private void AddOptionsToUserFilterBox()
        {
            userFilterBox.Items.Clear();
            var users = adminChatDashboardService.GetAllUsers();
            string option;
            userFilterBox.Items.Add("-");
            foreach (var user in users)
            {
                option = user.UserName;
                userFilterBox.Items.Add(option);
            }
        }

        private void LoadDataIntoTableUser(int id = -1)
        {
            ChatService _chatService = new ChatService();
            var roles = _chatService.ListRole(); 
            var users = adminChatDashboardService.GetAllUsers();
            if (id > 0) users = adminChatDashboardService.GetAllUsers().Where(e => e.Id == id);
            foreach (var user in users)
            {
                string roleName = roles.Where(i => i.Id == user.RoleId).First().Name;
                string[] users_data = new string[]
                {
                    user.Id.ToString(),
                    user.UserName,
                    user.EmailAdress,
                    user.Password,
                    user.Name,
                    user.LastName,
                    user.Blocked.ToString(),
                    roleName,
                    user.NickName,
                };

                ListViewItem list = new ListViewItem(users_data);
                list.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);

                if (roleName == "Chat_Admin") list.ForeColor = Color.LightGreen;
                else if (roleName == "Master_Admin") list.ForeColor = Color.YellowGreen;
                else list.ForeColor = Color.WhiteSmoke;

                usersList.Items.Add(list);
            }
        }

        private void ClearListUser()
        {
            usersList.Items.Clear();
        }

        public void UsersTableReload()
        {
            ClearListUser();
            LoadDataIntoTableUser();
            AddOptionsToUserFilterBox();
        }

        private void FilteringTableUsers()
        {
            string selectedVal = userFilterBox
                .SelectedItem
                .ToString();

            ClearListUser();
            if (selectedVal == "-" || selectedVal == "") LoadDataIntoTableUser();
            else
            {
                int selectedUserId = adminChatDashboardService
                    .GetAllUsers()
                    .Where(e => e.UserName == selectedVal)
                    .First()
                    .Id;

                LoadDataIntoTableUser(selectedUserId);
            }
        }

        private void userFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilteringTableUsers();
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {  
            AddOptionsToUserFilterBox();

            usersList.Columns.Add("Id", -2, HorizontalAlignment.Left);
            usersList.Columns.Add("Username", 100, HorizontalAlignment.Left);
            usersList.Columns.Add("Email", 120, HorizontalAlignment.Left);
            usersList.Columns.Add("Password", 120, HorizontalAlignment.Left);
            usersList.Columns.Add("Name", 100, HorizontalAlignment.Left);
            usersList.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            usersList.Columns.Add("Blocked", -2, HorizontalAlignment.Left);
            usersList.Columns.Add("RoleId", -2, HorizontalAlignment.Left);
            usersList.Columns.Add("Nickname", -2, HorizontalAlignment.Left);

            usersList.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);

            /*ImageList image = new ImageList();
            image.ImageSize = new Size(10, 10);
            string path = Path.GetFullPath(@"..\..\image\button\edit.png");
            image.Images.Add(Image.FromFile(path));
            adminChat.listUsers.SmallImageList = image;*/

            LoadDataIntoTableUser();

            usersList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            usersList.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);
            usersList.AutoResizeColumn(7, ColumnHeaderAutoResizeStyle.HeaderSize);
            usersList.AutoResizeColumn(8, ColumnHeaderAutoResizeStyle.ColumnContent);

            usersList.ItemActivate += new EventHandler(settingsUserAccount);
        }

        private void userFilterIcon_Click(object sender, EventArgs e)
        {
            userFilterBox.SelectedItem = "-";
            UsersTableReload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersTableReload();
        }
    }
}
