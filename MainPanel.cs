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

namespace Chat
{
    public partial class MainPanel : Form
    {
        private UC_Chat uc_chat;
        private Notification notification;
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
                uc_chat.SendMessageBtn.PerformClick();
                e.Handled = true;
            }
        }

        private void roomList_Load(object sender, EventArgs e)
        {
            roomList.Columns.Add("Id", -2, HorizontalAlignment.Left);
            roomList.Columns.Add("Name", -2, HorizontalAlignment.Left);
            roomList.Columns.Add("Password", -2, HorizontalAlignment.Left);
            roomList.Columns.Add("Blocked", -2, HorizontalAlignment.Left);

            LoadDataIntoTableRooms();

            roomList.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            roomList.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            roomList.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            roomList.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);

            label1.Text = GlobalVariables.Instance.globalId.ToString();
            /*roomList.ItemActivate += new EventHandler(connectBtn_Click);*/

        }

        public void LoadDataIntoTableRooms()
        {
            RoomListService roomListService = new RoomListService();
            var allRooms = roomListService.GetListOfAllRooms();

            foreach ( var room in allRooms ) 
            {
                string[] rooms_data = new string[]
                {
                    room.Id.ToString(),
                    room.Name,
                    room.Password,
                    room.Blocked.ToString()   
                };
                ListViewItem list = new ListViewItem(rooms_data);
                list.Font = new Font("Comic Sans MS", 10, FontStyle.Italic);

                /*if (rooms_data[3] == "true") list.ForeColor = Color.LightGreen;
                else if (roleName == "Master_Admin") list.ForeColor = Color.YellowGreen;
                else list.ForeColor = Color.WhiteSmoke;*/

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
    }
}
