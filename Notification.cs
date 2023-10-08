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
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationType(string type, string textContent)
        {
            string typeLower = type.ToLower();
            switch (typeLower)
            {
                case "success":
                    string path = @"..\..\image\notification\success.png";
                    string icon = @"..\..\image\icon\check.ico";
                    Color color = Color.LimeGreen;
                    Color colorTitle = Color.Lime;
                    string textTitle = "Success!";

                    NotificationStyling(color, colorTitle, path, icon, textTitle, textContent);
                    break;

                case "error":
                    path = @"..\..\image\notification\error.png";
                    icon = @"..\..\image\icon\error.ico";
                    color = Color.FromArgb(192, 0, 0);
                    colorTitle = Color.Red;
                    textTitle = "Error!";

                    NotificationStyling(color, colorTitle, path, icon, textTitle, textContent);
                    break;

                case "info":
                    path = @"..\..\image\notification\info.png";
                    icon = @"..\..\image\icon\information.ico";
                    color = Color.DodgerBlue;
                    colorTitle = Color.Blue;
                    textTitle = "Info!";

                    NotificationStyling(color, colorTitle, path, icon, textTitle, textContent);
                    break;

                case "warning":
                    path = @"..\..\image\notification\warning.png";
                    icon = @"..\..\image\icon\warning.ico";
                    color = Color.FromArgb(255, 128, 0);
                    colorTitle = Color.Orange;
                    textTitle = "Warning!";

                    NotificationStyling(color, colorTitle, path, icon, textTitle, textContent);
                    break;

                default: this.Close();
                    break;
            }
        }
        private Bitmap bitmap;
        private void NotificationStyling(Color color, Color colorTitle, string image, string icon, string textTitle, string textContent)
        {
            notifTitlelabel.ForeColor = colorTitle;
            notifTitlelabel.Text = textTitle;

            notifContentLabel.ForeColor = color;
            notifContentLabel.Text = textContent;

            notifiOkBtn.ForeColor = colorTitle;
            notifiOkBtn.FlatAppearance.BorderColor = color;

            bitmap = new Bitmap(image);
            notifiImageBox.BackgroundImage = (Image) bitmap;

            this.Icon = new Icon(icon);
            this.Text = textTitle;

            /*this.FormBorderStyle = FormBorderStyle;*/
        }

        public void GetNotification(string type, string textContent)
        { 
            this.Show();
            NotificationType(type, textContent);
        }
    }
}
