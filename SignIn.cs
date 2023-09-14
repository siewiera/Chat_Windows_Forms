using Chat.Entities;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class SignIn : Form
    {
        private readonly ChatDbContext _dbContext;

        public SignIn()
        {
            InitializeComponent();
            _dbContext = new ChatDbContext();
            var service = new ChatService(_dbContext);
            service.AddDataToDatabase();
        }

        private void exit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signUpBtn_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void signInBtn_Click_1(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            DashboardChat chat = new DashboardChat();
            SettingsAccount settingsAccount = new SettingsAccount();
            var signInService = new SignInService(_dbContext);
            int check = signInService.GetDataInLogin(login, password);

            if (check == 100) 
            {
                this.Hide();
                settingsAccount.Show();
            }
            else
            {
                loginBox.Text = "";
                passwordBox.Text = "";
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
