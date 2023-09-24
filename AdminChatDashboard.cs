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
        private AdminChatDashboardService adminChatDashboardService = new AdminChatDashboardService();
        private ChatService _chatService = new ChatService();
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

        private void usersButton_Click(object sender, EventArgs e)
        {
            listUsers.View = View.Details;
            listUsers.Columns.Add("Id", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Username", 100, HorizontalAlignment.Center);
            listUsers.Columns.Add("Email", 120, HorizontalAlignment.Center);
            listUsers.Columns.Add("Password", 120, HorizontalAlignment.Center);
            listUsers.Columns.Add("Name", 100, HorizontalAlignment.Center);
            listUsers.Columns.Add("Lastname", 100, HorizontalAlignment.Center);
            listUsers.Columns.Add("Blocked", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("RoleId", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Nickname", -2, HorizontalAlignment.Center);

            listUsers.Font = new Font("Comic Sans MS", 10, FontStyle.Bold);


            /*ImageList image = new ImageList();
            image.ImageSize = new Size(10, 10);
            string path = Path.GetFullPath(@"..\..\image\button\edit.png");
            image.Images.Add(Image.FromFile(path));
            listUsers.SmallImageList = image;*/

            var roles = _chatService.ListRole();
            var users = adminChatDashboardService.GetAllUsers();
            foreach (var user in users)
            {
                string[] users_data = new string[]
                {
                    user.Id.ToString(),
                    user.UserName.ToString(),
                    user.EmailAdress.ToString(),
                    user.Password.ToString(),
                    user.Name.ToString(),
                    user.LastName.ToString(),
                    user.Blocked.ToString(),
                    user.RoleId.ToString(),
                    user.NickName.ToString(),
                };

                ListViewItem list = new ListViewItem(users_data);
                list.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);

                foreach (var role in roles.Where(i => i.Id == user.RoleId))
                {
                    if (role.Name == "Chat_Admin") list.ForeColor = Color.Green;
                    else if (role.Name == "Master_Admin") list.ForeColor = Color.YellowGreen;
                    else list.ForeColor = Color.White;
                }
                listUsers.Items.Add(list);          
            }

            listUsers.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            listUsers.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);
            listUsers.AutoResizeColumn(7, ColumnHeaderAutoResizeStyle.HeaderSize);
            listUsers.AutoResizeColumn(8, ColumnHeaderAutoResizeStyle.ColumnContent);
            
            listUsers.ItemActivate += new EventHandler(settingsUserAccount);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminChatDashboard_Load(object sender, EventArgs e)
        {        
            
        }
    }
}
