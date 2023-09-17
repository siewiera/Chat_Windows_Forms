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
        public SignIn()
        {
            InitializeComponent();
            var service = new ChatService();
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

            AdminChatDashboard adminChatDashboard = new AdminChatDashboard();
            
            var signInService = new SignInService();
            int check = signInService.GetDataInLogin(login, password);

            if (check == 100) 
            {
                int id = GlobalVariables.Instance.globalId;
                SettingsAccount settingsAccount = new SettingsAccount(id);
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
