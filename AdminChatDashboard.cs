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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chat
{
    public partial class AdminChatDashboard : Form
    {
        AdminChatDashboardService adminChatDashboardService = new AdminChatDashboardService(); 
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

        public void test(object sender, EventArgs e)
        {
            SettingsAccount settings = new SettingsAccount(4);
            settings.Show();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {

            ImageList image = new ImageList();
            image.ImageSize = new Size(50, 50);
            Graphics theGraphics = Graphics.FromHwnd(this.Handle);

            listUsers.View = View.Details;

            listUsers.Columns.Add("Id", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Username", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Email", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Password", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Name", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Lastname", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Blocked", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("RoleId", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Nickname", -2, HorizontalAlignment.Center);
            listUsers.Columns.Add("Settings", -2, HorizontalAlignment.Center);

            string path = "C:/Users/BPX S Siewiera/source/repos/siewiera/Chat_Windows_Forms/image/button/save.png";
            image.Images.Add(Image.FromFile(path));

            var users = adminChatDashboardService.GetAllUsers();

            listUsers.SmallImageList = image;

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


                listUsers.Items.Add(new ListViewItem(users_data, 0));
            }
            /*listUsers.Items.Add("", 0);
            listUsers.EndUpdate();*/
            listUsers.ItemActivate += new EventHandler(test);
            listUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            /*listUsers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);*/
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminChatDashboard_Load(object sender, EventArgs e)
        {        
            
        }
    }
}
