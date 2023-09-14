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

        private readonly LoggedUserService loggedUserService;
        private readonly ChatDbContext _dbContext;
        public SettingsAccount(ChatDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            /*ChatDbContext dbContext = new ChatDbContext();*/
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
            LoggedUserService loggedUserService = new LoggedUserService();
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
            var user = new User()
            {
                NickName = nicknameBox.Text,
                UserName = usernameBox.Text,
                EmailAdress = emailBox.Text,
                Password = passwordBox.Text,
                Name = nameBox.Text,
                LastName = lastNameBox.Text,
                Blocked = blockedChb.Checked,
                /*RoleId = 9,*/
            };

/*wrzucic do settings account service*/
            dbContext.Users.AddRange(user);
            dbContext.SaveChanges();
        }
    }
}
