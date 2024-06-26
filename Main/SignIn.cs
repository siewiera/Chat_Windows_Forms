﻿using Chat.Entities;
using Chat.Services;
using Microsoft.Win32;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Chat
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            var service = new ChatService();
            service.AddDataToDatabase();

            KeyPreview = true;
            KeyDown += SignIn_KeyPress;
        }

        /* użycie przycisku Send z chatu po klawiszu Enter */
        private void SignIn_KeyPress(object sender, KeyEventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            Notification notification = new Notification();
            MainPanel mainPanel = new MainPanel();
            

            if (e.KeyCode == Keys.Enter)
            {
                var signInService = new SignInService();
                int check = signInService.GetDataInLogin(login, password);

                if (check == 100)
                {
                    signInBtn_Click_1(sender, EventArgs.Empty);
                    e.Handled = true;
                }
            }
        }

        private void exit_Click_2(object sender, EventArgs e)
        {
            /*this.Close();*/
            Environment.Exit(0);
        }

        private async void signUpBtn_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            InitializingEnviroment init = new InitializingEnviroment();
            string[] exe = new string[]{ };

            await init.LoadInitData(this, register, exe);
        }

        private async void signInBtn_Click_1(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            MainPanel mainPanel = new MainPanel();
            
            var signInService = new SignInService();
            int check = signInService.GetDataInLogin(login, password);

            if (check == 100) 
            {
                InitializingEnviroment init = new InitializingEnviroment();
                string[] exe = new string[] 
                {
                    "updateControls", 
                    "updateRooms", 
                };          
                await init.LoadInitData(this, mainPanel, exe);
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
