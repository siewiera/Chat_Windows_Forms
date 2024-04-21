using Chat.Entities;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Chat.Services.SettingsAccountService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chat
{
    public partial class MainPanel : Form
    {
        private UC_Chat uc_chat;
        private Notification notification;
        static System.Timers.Timer timer;

        public MainPanel()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += ClickSend_KeyPress;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            /*this.Close();*/
            Environment.Exit(0);
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.resizeBtn.BackgroundImage = Properties.Resources.increase;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.resizeBtn.BackgroundImage = Properties.Resources.reduce_1_;
            }

            float scaleX = (float)this.Width / panel1.Width;
            float scaleY = (float)this.Height / panel1.Height;

            panel1.Width = (int)(panel1.Width * scaleX);
            panel1.Height = (int)(panel1.Height * scaleY);
            
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /* użycie przycisku Send z chatu po klawiszu Enter */
        private void ClickSend_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!e.Control && e.KeyCode == Keys.Enter)
                {
                    uc_chat.SendMessageBtn_Click(this, EventArgs.Empty);
                    e.Handled = true;
                }
            }
        }

        private async void roomList_Load(object sender, EventArgs e)
        {
            LoadDataIntoTableRooms();

            timer = new System.Timers.Timer(5000);
            timer.Elapsed += async (se, ev) => await loadUserDataDetails();
            timer.Start();
        }

        public async Task loadUserDataDetails()
        {
            await Task.Run(() =>
            {
                int user_id = GlobalVariables.Instance.globalId;
                LoggedUserService loggedUserService = new LoggedUserService(user_id);

                emailDetailsLabel.Invoke((MethodInvoker)delegate 
                { 
                    emailDetailsLabel.Text = loggedUserService.GetEmail();  
                });

                fullNameDetailsLabel.Invoke((MethodInvoker)delegate 
                { 
                    fullNameDetailsLabel.Text = loggedUserService.GetName() + " " + loggedUserService.GetLastName();  
                });
                    
            });
        }

        public void LoadDataIntoTableRooms()
        {
            RoomListService roomListService = new RoomListService();
            var allRooms = roomListService.GetListOfAllRooms();
            bool secured = false;

            foreach ( var room in allRooms ) 
            {
                if(room.Password != null && room.Password != "") 
                    secured = true;

                string[] rooms_data = new string[]
                {
                    room.Id.ToString(),
                    room.Name,
                    secured.ToString(),
                };
                ListViewItem list = new ListViewItem(rooms_data);
                list.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);

                roomList.Items.Add(list);
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (roomList.SelectedItems.Count <= 0)
            {
                notification = new Notification();
                notification.GetNotification("Error", "Select the room you want to connect to");
            }
            else
            {
                panel1.Controls.Remove(uc_chat);
                string id_room = roomList.SelectedItems[0].Text;
                string name_room = roomList.SelectedItems[0].SubItems[1].Text;
                uc_chat = new UC_Chat(Int32.Parse(id_room), name_room);
                panel1.Controls.Add(uc_chat);
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            int user_id = GlobalVariables.Instance.globalId;
            SettingsAccount settingsAccount = new SettingsAccount(user_id);
            settingsAccount.Show();
        }

        private void adminPanelBtn_Click(object sender, EventArgs e)
        {
            AdminChatDashboard adminChatDashboard = new AdminChatDashboard(); 
            adminChatDashboard.Show();
        }
    }
}
