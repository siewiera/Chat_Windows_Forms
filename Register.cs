using Chat.Entities;
using Chat.Services;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Chat
{
    public partial class Register : Form
    {
        private readonly ChatDbContext _dbContext = new ChatDbContext();
        private SignIn signIn = new SignIn();
        public Register()
        {
            InitializeComponent();
        }
    

        private async void signInButton_Click(object sender, EventArgs e)
        {
            /*signIn.Show();
            this.Hide();*/
            InitializingEnviroment init = new InitializingEnviroment();
            string[] exe = new string[] { };

            await init.LoadInitData(this, signIn, exe);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            /*this.Close();*/
            Environment.Exit(0);
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;

            var checkRegistration = new RegistrationService().CheckRegister(login, email, password);
            if (checkRegistration)
            {
                /*this.Hide();
                signIn.Show();*/
                InitializingEnviroment init = new InitializingEnviroment();
                string[] exe = new string[] { };

                await init.LoadInitData(this, signIn, exe);
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
