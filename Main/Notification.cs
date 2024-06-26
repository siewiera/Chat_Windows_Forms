﻿using Chat.Properties;
using Chat.Services.Button;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Chat
{
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
        }

        private Bitmap bitmap;
        public bool check;

        private void NotificationType(string type, string textContent, bool yesNoBtn)
        {
            string typeLower = type.ToLower();
            bool check_;
            
            switch (typeLower)
            {
                case "success":
                    string path = @"..\..\image\notification\success2.png";
                    string icon = @"..\..\image\icon\check.ico";
                    Color color = Color.LimeGreen;
                    Color colorTitle = Color.Lime;
                    string textTitle = "Success!";

                    NotificationStyling(color, colorTitle, path, icon, textTitle, textContent, yesNoBtn);
                    break;

                case "error":
                    path = @"..\..\image\notification\error2.png";
                    icon = @"..\..\image\icon\error.ico";
                    color = Color.FromArgb(192, 0, 0);
                    colorTitle = Color.Red;
                    textTitle = "Error!";

                    NotificationStyling(color, colorTitle, path, icon, textTitle, textContent, yesNoBtn);
                    break;

                case "info":
                    path = @"..\..\image\notification\info2.png";
                    icon = @"..\..\image\icon\information.ico";
                    color = Color.RoyalBlue;
                    colorTitle = Color.DodgerBlue;
                    textTitle = "Info!";

                    NotificationStyling(color, colorTitle, path, icon, textTitle, textContent, yesNoBtn);
                    break;

                case "warning":
                    path = @"..\..\image\notification\warning2.png";
                    icon = @"..\..\image\icon\warning.ico";
                    color = Color.FromArgb(255, 128, 0);
                    colorTitle = Color.Orange;
                    textTitle = "Warning!";

                    NotificationStyling(color, colorTitle, path, icon, textTitle, textContent, yesNoBtn);
                    break;

                default: 
                    this.Close();
                    break;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.check = false;
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.check = true;
            this.Close();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.check = true;
            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.check = false;
            this.Close();
        }
        private void NotificationStyling(Color color, Color colorTitle, string image, 
            string icon, string textTitle, string textContent, bool yesNoBtn)
        {
            notifTitlelabel.ForeColor = colorTitle;
            notifTitlelabel.Text = textTitle;

            notifContentLabel.ForeColor = color;
            notifContentLabel.Text = textContent;

            bitmap = new Bitmap(image);
            notifiImageBox.BackgroundImage = (Image) bitmap;

            char[] chars = { '!' };
            this.Icon = new Icon(icon);
            this.Text = textTitle.TrimEnd(chars).ToLower();

            this.BackColor = color;

            ButtonsService buttonsService = new ButtonsService();
            Bitmap bitmapEmpty = null;

            if (yesNoBtn)
            {
                Button yesBtn = new Button();
                Button noBtn = new Button();

                Color colorGreen = Color.LimeGreen;
                Color colorTitleGreen = Color.Lime;

                Color colorRed = Color.FromArgb(192, 0, 0);
                Color colorTitleRed = Color.Red;
                

                buttonsService.GeneratingButtons(yesBtn, "Yes", bitmapEmpty, bitmapEmpty, colorGreen, colorTitleGreen, 2, 10, new System.Drawing.Point(175, 120),
                    "notifYesBtn", new System.Drawing.Size(120, 30), yesBtn_Click);

                buttonsService.GeneratingButtons(noBtn, "No", bitmapEmpty, bitmapEmpty, colorRed, colorTitleRed, 2, 10, new System.Drawing.Point(20, 120),
                    "notifNoBtn", new System.Drawing.Size(120, 30), noBtn_Click);

                notificationPanel.Controls.Add(yesBtn);
                notificationPanel.Controls.Add(noBtn);

            }
            else {
                Button okBtn = new Button();

                buttonsService.GeneratingButtons(okBtn, "OK", bitmapEmpty, bitmapEmpty, color, colorTitle, 2, 10, new System.Drawing.Point(100, 120),
                    "notifOkBtn", new System.Drawing.Size(120, 30), okBtn_Click);

                notificationPanel.Controls.Add(okBtn);
            }
        }

        public bool GetNotification(string type, string textContent, bool yesNoBtn = false)
        {            
            NotificationType(type, textContent, yesNoBtn);
            this.ShowDialog();

            return this.check;
        }
    }
}
