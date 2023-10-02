using Chat.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Chat.Services.SettingsAccountService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chat
{
    public partial class AdminChatDashboard : Form
    {
        private ChatService _chatService = new ChatService();
        private AdminChatDashboardService adminChatDashboardService = new AdminChatDashboardService();
        public AdminChatDashboard()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {         
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;       
        }

        private void resize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.resize.BackgroundImage = Properties.Resources.increase;
            }
            else 
            {
                this.WindowState = FormWindowState.Maximized;
                this.resize.BackgroundImage = Properties.Resources.reduce_1_;
            }
        }

        private void chanelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            int idLoggedUser = GlobalVariables.Instance.globalId;
            SettingsAccount settingsAccount = new SettingsAccount(idLoggedUser);

            settingsAccount.Show();
        }

        public void settingsUserAccount(object sender, EventArgs e)
        {
            string id = listUsers.SelectedItems[0].Text;
            SettingsAccount settings = new SettingsAccount(Int32.Parse(id));
            settings.Show();
        }

        private void AddOptionsToUserFilterBox()
        {
            var users = adminChatDashboardService.GetAllUsers();
            string option;
            userFilterBox.Items.Add("-");
            foreach (var user in users)
            {
                /*if(user.Name == "") option = user.UserName;
                else option = $"{user.Name} {user.LastName} ({user.UserName})";*/
                option = user.UserName;
                userFilterBox.Items.Add(option);
            }
        }

        private void ChangingVisibiltyModules(string module,  bool visible = true)
        {
            switch (module) 
            {
                case "Channels":
                    break;
                case "Users":
                    listUsers.Visible = visible;
                    userFilterBox.Visible = visible;
                    userFilterIcon.Visible = visible;
                    break;
                case "Roles":
                    break;
                case "Message":
                    break;
            }
            
        }

        private void LoadDataIntoTableUser(int id = -1)
        {
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

                listUsers.Items.Add(list);
            }
        }

        private void ClearListUser()
        { 
            listUsers.Items.Clear();
        }

        

        private void usersButton_Click(object sender, EventArgs e)
        {

            if (listUsers.Visible) return;

            ChangingVisibiltyModules("Users", true);
            AddOptionsToUserFilterBox();

            listUsers.Columns.Add("Id", -2, HorizontalAlignment.Left);
            listUsers.Columns.Add("Username", 100, HorizontalAlignment.Left);
            listUsers.Columns.Add("Email", 120, HorizontalAlignment.Left);
            listUsers.Columns.Add("Password", 120, HorizontalAlignment.Left);
            listUsers.Columns.Add("Name", 100, HorizontalAlignment.Left);
            listUsers.Columns.Add("Lastname", 100, HorizontalAlignment.Left);
            listUsers.Columns.Add("Blocked", -2, HorizontalAlignment.Left);
            listUsers.Columns.Add("RoleId", -2, HorizontalAlignment.Left);
            listUsers.Columns.Add("Nickname", -2, HorizontalAlignment.Left);

            listUsers.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);

            /*ImageList image = new ImageList();
            image.ImageSize = new Size(10, 10);
            string path = Path.GetFullPath(@"..\..\image\button\edit.png");
            image.Images.Add(Image.FromFile(path));
            adminChat.listUsers.SmallImageList = image;*/

            LoadDataIntoTableUser();

            listUsers.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listUsers.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);
            listUsers.AutoResizeColumn(7, ColumnHeaderAutoResizeStyle.HeaderSize);
            listUsers.AutoResizeColumn(8, ColumnHeaderAutoResizeStyle.ColumnContent);

            listUsers.ItemActivate += new EventHandler(settingsUserAccount);
        }


        private void AdminChatDashboard_Load(object sender, EventArgs e)
        {

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
    }
}
