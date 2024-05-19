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
        private PermissionsManagement permissionsManagement;
        private UC_Roles uc_roles = new UC_Roles();
        private UC_Users uc_users = new UC_Users();

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

        private void ChangingVisibiltyModules(string module,  bool visible = true)
        {
            chanelButton.ForeColor = Color.White;
            chanelButton.FlatAppearance.BorderColor = Color.White;

            usersButton.ForeColor = Color.White;
            usersButton.FlatAppearance.BorderColor = Color.White;

            roleButton.ForeColor = Color.White;
            roleButton.FlatAppearance.BorderColor = Color.White;

            messageButton.ForeColor = Color.White;
            messageButton.FlatAppearance.BorderColor = Color.White;

            panelAdmin.Controls.Remove(uc_roles);
            panelAdmin.Controls.Remove(uc_users);

            switch (module) 
            {
                case "Channels":
                    break;
                case "Users":
                    panelAdmin.Controls.Add(uc_users);
                    if (visible == true)
                    {
                        usersButton.ForeColor = Color.MediumSpringGreen;
                        usersButton.FlatAppearance.BorderColor = Color.MediumSpringGreen;
                    }
                    break;
                case "Roles":
                    panelAdmin.Controls.Add(uc_roles);
                    if (visible == true)
                    {
                        roleButton.ForeColor = Color.MediumSpringGreen;
                        roleButton.FlatAppearance.BorderColor = Color.MediumSpringGreen;
                    }
                    break;
                case "Message":
                    break;
            }
            
        }  

        private void usersButton_Click(object sender, EventArgs e)
        {
            ChangingVisibiltyModules("Users", true);
        }

        private void AdminChatDashboard_Load(object sender, EventArgs e)
        {
            permissionsManagement = new PermissionsManagement(this);
            permissionsManagement.CheckingPermissions();

            int idLogged = GlobalVariables.Instance.globalId;
            if (idLogged == 0) return;
            string emailLogged = adminChatDashboardService.GetAllUsers().Where(a => a.Id == idLogged).First().EmailAdress;

            labelLoggedUserEmail.Text = emailLogged;
        }

        private void roleButton_Click(object sender, EventArgs e)
        {
            ChangingVisibiltyModules("Roles", true); 
        }
    }
}
