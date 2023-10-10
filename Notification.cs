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
        private Bitmap bitmap;
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

                yesBtn.Text = "Yes";
                /*yesBtn.ForeColor = Color.LimeGreen;
                yesBtn.FlatAppearance.BorderColor = Color.White;*/
                yesBtn.Location = new Point(102, 100);
                yesBtn.Size = new Size(175, 49);

                yesBtn.Click += new EventHandler(exit_Click);
                /*noBtn.ForeColor = Color.Red;
                noBtn.FlatAppearance.BorderColor = Color.White;
                noBtn.PointToScreen(new Point(33, 180));
                noBtn.Size = new Size(175, 49);*/
                notificationPanel.Controls.Add(yesBtn);
            }
        }

        public void GetNotification(string type, string textContent, bool yesNoBtn = false)
        { 
            this.Show();
            NotificationType(type, textContent, yesNoBtn);
        }
    }
}
