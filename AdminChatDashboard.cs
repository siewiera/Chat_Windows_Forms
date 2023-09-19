using Chat.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public void test(object sender, EventArgs e, int i)
        {
            SettingsAccount settings = new SettingsAccount(2);
            settings.Show();
        }

        private void usersButton_Click(object sender, EventArgs e, int i)
        {

            /*ListViewItem entryListItem = listUsers.Items.Add("Settings");
            entryListItem.UseItemStyleForSubItems = false;
            entryListItem.SubItems.Add("settings");*/

            listUsers.Columns.Add("Id");
            listUsers.Columns.Add("Username");
            listUsers.Columns.Add("Email");
            listUsers.Columns.Add("Password");
            listUsers.Columns.Add("Name");
            listUsers.Columns.Add("Lastname");
            listUsers.Columns.Add("Blocked");
            listUsers.Columns.Add("RoleId");
            listUsers.Columns.Add("Nickname");
            listUsers.Columns.Add("Settings");

            
            /*listUsers.Columns.Add("Settings");*/

           /* listUsers.MouseClick += new MouseEventHandler(test);*/

            var users = adminChatDashboardService.GetAllUsers();
            foreach (var user in users)
            {
                listUsers.Items.Add(new ListViewItem
                    (new string[]
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
                            "Settings",
                        }                
                    )
                    /*listUsers.Items.Add("Settings");*/
                );
                
                
            }
            /*listUsers.li = true;*/
            /*listUsers.MouseClick += new MouseEventHandler(test);*/
;
            listUsers.ItemActivate += new EventHandler(test);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminChatDashboard_Load(object sender, EventArgs e)
        {        
            
        }
    }
}
