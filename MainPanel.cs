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
        private UC_Chat uc_chat = new UC_Chat(); 
        public MainPanel()
        {
            InitializeComponent();
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


            /*roomList.ItemActivate += new EventHandler(settingsUserAccount);*/
            
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
            panel1.Controls.Add(uc_chat);
        }
    }
}
