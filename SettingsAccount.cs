using Chat.Entities;
using Chat.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Chat
{
    public partial class SettingsAccount : Form
    {

        SettingsAccountService settingsAccountService = new SettingsAccountService();
        LoggedUserService loggedUserService = new LoggedUserService();
        public SettingsAccount()
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

        public void blockedChb_CheckedChanged(object sender, EventArgs e)
        {
            if (blockedChb.Checked == true)
            {
                blockedChb.Image = Properties.Resources.check_red;
            }
            else
            {
                blockedChb.Image = null;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
/*przenieść do settingsaccountservice*/
            usernameBox.Text = loggedUserService.GetUsername();
            nameBox.Text = loggedUserService.GetName();
            lastNameBox.Text = loggedUserService.GetLastName();
            passwordBox.Text = loggedUserService.GetPassword();
            passwordBox2.Text = loggedUserService.GetPassword();
            emailBox.Text = loggedUserService.GetEmail();
            nicknameBox.Text = loggedUserService.GetNickname();
            blockedChb.Checked = loggedUserService.IsBlocked();
            blockedChb_CheckedChanged(sender, e);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DashboardChat dashboardChat = new DashboardChat();
            this.Close();
            dashboardChat.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            settingsAccountService.SavingUserData(nicknameBox.Text, usernameBox.Text, emailBox.Text,
                passwordBox.Text, nameBox.Text, lastNameBox.Text, blockedChb.Checked);
        }
    }
}
