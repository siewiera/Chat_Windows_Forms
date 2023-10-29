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
            button.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
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

            if (yesNoBtn)
            {
                Button yesBtn = new Button();
                Button noBtn = new Button();

                Color colorGreen = Color.LimeGreen;
                Color colorTitleGreen = Color.Lime;

                Color colorRed = Color.FromArgb(192, 0, 0);
                Color colorTitleRed = Color.Red;

                GeneratingButtons(yesBtn, "Yes", colorGreen, colorTitleGreen, new System.Drawing.Point(175, 120),
                    "notifYesBtn", new System.Drawing.Size(120, 30), yesBtn_Click);

                GeneratingButtons(noBtn, "No", colorRed, colorTitleRed, new System.Drawing.Point(20, 120),
                    "notifNoBtn", new System.Drawing.Size(120, 30), noBtn_Click);
            }
            else {
                Button okBtn = new Button();

                GeneratingButtons(okBtn, "OK", color, colorTitle, new System.Drawing.Point(100, 120),
                    "notifOkBtn", new System.Drawing.Size(120, 30), okBtn_Click);
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
