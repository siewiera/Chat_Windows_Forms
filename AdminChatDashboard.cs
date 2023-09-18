﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class AdminChatDashboard : Form
    {
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
            SettingsAccount settingsAccount = new SettingsAccount(7);

            settingsAccount.Show();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {

        }
    }
}
