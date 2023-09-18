using Chat.Entities;
using Chat.Services;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        private SettingsAccountService settingsAccountService;
        public SettingsAccount(int id)
        {
            InitializeComponent();
            settingsAccountService = new SettingsAccountService(id);
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

            var userData = settingsAccountService.LoadUserData();

            idBox.Text = userData.id.ToString();
            usernameBox.Text = userData.username;
            nameBox.Text = userData.name;
            lastNameBox.Text = userData.lastname;
            passwordBox.Text = userData.password;
            passwordBox2.Text = "";
            emailBox.Text = userData.email;
            nicknameBox.Text = userData.nickname;
            blockedChb.Checked = userData.blocked;
           
            blockedChb_CheckedChanged(sender, e);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {       
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idBox.Text);
            string nickname = nicknameBox.Text;
            string username = usernameBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;
            string name = nameBox.Text;
            string lastname = lastNameBox.Text;
            bool blocked = blockedChb.Checked;

            bool check = settingsAccountService
                    .SavingUserData(id, nickname, username, email, password, name, lastname, blocked);

            if (check)
            {
                this.Close();
            }
        }
    }
}
