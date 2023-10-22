using Chat.Properties;
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

        private void notifiOkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool NotificationType(string type, string textContent, bool yesNoBtn)
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

                    check_ = NotificationStyling(color, colorTitle, path, icon, textTitle, textContent, yesNoBtn);
                    break;

                case "error":
                    path = @"..\..\image\notification\error2.png";
                    icon = @"..\..\image\icon\error.ico";
                    color = Color.FromArgb(192, 0, 0);
                    colorTitle = Color.Red;
                    textTitle = "Error!";

                    check_ = NotificationStyling(color, colorTitle, path, icon, textTitle, textContent, yesNoBtn);
                    break;

                case "info":
                    path = @"..\..\image\notification\info2.png";
                    icon = @"..\..\image\icon\information.ico";
                    color = Color.RoyalBlue;
                    colorTitle = Color.DodgerBlue;
                    textTitle = "Info!";

                    check_ = NotificationStyling(color, colorTitle, path, icon, textTitle, textContent, yesNoBtn);
                    break;

                case "warning":
                    path = @"..\..\image\notification\warning2.png";
                    icon = @"..\..\image\icon\warning.ico";
                    color = Color.FromArgb(255, 128, 0);
                    colorTitle = Color.Orange;
                    textTitle = "Warning!";

                    check_ = NotificationStyling(color, colorTitle, path, icon, textTitle, textContent, yesNoBtn);
                    break;

                default: 
                    this.Close();
                    check_ = false;
                    break;
            }

            return check_;
        }

        private void GeneratingButtons(Button button, string textButton, Color borderColor, Color textColor,
            System.Drawing.Point point, string nameButton, System.Drawing.Size sizeButton, EventHandler ev)
        {
            button.Text = textButton;
            button.BackColor = Color.Transparent;
            button.BackgroundImageLayout = ImageLayout.None;
            button.FlatAppearance.BorderColor = borderColor;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
            button.ForeColor = textColor;
            button.Location = point;
            button.Margin = new Padding(0);
            button.Name = nameButton;
            button.Size = sizeButton;
            button.TextImageRelation = TextImageRelation.TextBeforeImage;
            button.UseVisualStyleBackColor = false;           
            button.Click += ev;

            notificationPanel.Controls.Add(button);
        }

        private void yes_Click(object sender, EventArgs e)
        {
            check = true;
            this.Close();
        }

        private void no_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }
        private bool NotificationStyling(Color color, Color colorTitle, string image, 
            string icon, string textTitle, string textContent, bool yesNoBtn)
        {
            notifTitlelabel.ForeColor = colorTitle;
            notifTitlelabel.Text = textTitle;

            notifContentLabel.ForeColor = color;
            notifContentLabel.Text = textContent;

            notifiOkBtn.ForeColor = colorTitle;
            notifiOkBtn.FlatAppearance.BorderColor = color;

            bitmap = new Bitmap(image);
            notifiImageBox.BackgroundImage = (Image) bitmap;

            char[] chars = { '!' };
            this.Icon = new Icon(icon);
            this.Text = textTitle.TrimEnd(chars).ToLower();

            this.BackColor = color;

            if (yesNoBtn)
            {
                this.Controls.Remove(notifiOkBtn);
                notifiOkBtn.Dispose();

                Button yesBtn = new Button();
                Button noBtn = new Button();

                Color colorGreen = Color.LimeGreen;
                Color colorTitleGreen = Color.Lime;
                Color colorRed = Color.FromArgb(192, 0, 0);
                Color colorTitleRed = Color.Red;

                /*GeneratingButtons(yesBtn, "Yes", colorGreen, colorTitleGreen, new System.Drawing.Point(185, 110),
                    "notifiYesBtn", new System.Drawing.Size(120, 35), yes_Click);

                GeneratingButtons(noBtn, "No", colorRed, colorTitleRed, new System.Drawing.Point(10, 110),
                    "notifiNoBtn", new System.Drawing.Size(120, 35), no_Click);*/


                yesBtn.Text = "Yes";
                yesBtn.BackColor = Color.Transparent;
                yesBtn.BackgroundImageLayout = ImageLayout.None;
                yesBtn.FlatAppearance.BorderColor = colorGreen;
                yesBtn.FlatAppearance.BorderSize = 2;
                yesBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                yesBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                yesBtn.FlatStyle = FlatStyle.Flat;
                yesBtn.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                yesBtn.ForeColor = colorTitleGreen;
                yesBtn.Location = new System.Drawing.Point(185, 110);
                yesBtn.Margin = new Padding(0);
                yesBtn.Name = "notifiOkBtn";
                yesBtn.Size = new System.Drawing.Size(120, 35);
                yesBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                yesBtn.UseVisualStyleBackColor = false;
                yesBtn.Click += new EventHandler(yes_Click);

                noBtn.Text = "No";
                noBtn.BackColor = Color.Transparent;
                noBtn.BackgroundImageLayout = ImageLayout.None;
                noBtn.FlatAppearance.BorderColor = colorRed;
                noBtn.FlatAppearance.BorderSize = 2;
                noBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                noBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                noBtn.FlatStyle = FlatStyle.Flat;
                noBtn.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
                noBtn.ForeColor = colorTitleRed;
                noBtn.Location = new System.Drawing.Point(10, 110);
                noBtn.Margin = new Padding(0);
                noBtn.Name = "notifiOkBtn";
                noBtn.Size = new System.Drawing.Size(120, 35);
                noBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                noBtn.UseVisualStyleBackColor = false;
                noBtn.Click += new EventHandler(no_Click);


                notificationPanel.Controls.Add(noBtn);
                notificationPanel.Controls.Add(yesBtn);
            }

            return check;
        }

        public bool GetNotification(string type, string textContent, bool yesNoBtn = false)
        {            
            bool check_ = NotificationType(type, textContent, yesNoBtn);
            this.ShowDialog();

            return check_;
        }
    }
}
