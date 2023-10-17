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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NotificationType(string type, string textContent, bool yesNoBtn)
        {
            string typeLower = type.ToLower();
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

                default: this.Close();
                    break;
            }
        }
        
        private void NotificationStyling(Color color, Color colorTitle, string image, 
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

                yesBtn.Text = "Yes";
                yesBtn.BackColor = Color.Transparent;
                yesBtn.BackgroundImageLayout = ImageLayout.None;
                yesBtn.FlatAppearance.BorderColor = colorGreen;
                yesBtn.FlatAppearance.BorderSize = 2;
                yesBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                yesBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                yesBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                yesBtn.ForeColor = colorTitleGreen;
                yesBtn.Location = new Point(182, 110);
                yesBtn.Margin = new Padding(0);
                yesBtn.Name = "notifiOkBtn";
                yesBtn.Size = new Size(120, 35);
                yesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
                yesBtn.UseVisualStyleBackColor = false;
                yesBtn.Click += new EventHandler(exit_Click);

                noBtn.Text = "No";
                noBtn.BackColor = Color.Transparent;
                noBtn.BackgroundImageLayout = ImageLayout.None;
                noBtn.FlatAppearance.BorderColor = colorRed;
                noBtn.FlatAppearance.BorderSize = 2;
                noBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
                noBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
                noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                noBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                noBtn.ForeColor = colorTitleRed;
                noBtn.Location = new Point(10, 110);
                noBtn.Margin = new Padding(0);
                noBtn.Name = "notifiOkBtn";
                noBtn.Size = new Size(120, 35);
                noBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
                noBtn.UseVisualStyleBackColor = false;
                noBtn.Click += new EventHandler(exit_Click);

                notificationPanel.Controls.Add(yesBtn);
                notificationPanel.Controls.Add(noBtn);
            }
        }

        public void GetNotification(string type, string textContent, bool yesNoBtn = false)
        { 
            this.ShowDialog();
            NotificationType(type, textContent, yesNoBtn);
        }
    }
}
