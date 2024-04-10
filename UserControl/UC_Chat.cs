using Chat.Entities;
using Chat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Chat.Services.SettingsAccountService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Chat
{
    public partial class UC_Chat : UserControl
    {
        private UC_ChatService uc_chatService = new UC_ChatService();
        private LoggedUserService _loggedUserService;
        private readonly int id;
        private readonly string name_room;

        public UC_Chat(int id, string name_room)
        {
            InitializeComponent();

            int idLoggedUser = GlobalVariables.Instance.globalId;
            if (idLoggedUser == null || idLoggedUser == 0) idLoggedUser = 14;

            _loggedUserService = new LoggedUserService(idLoggedUser);
            this.id = id;
            this.name_room = name_room;
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();

            string message = MessageFieldTBox.Text;
            string user_fullName = _loggedUserService.GetName() + ' ' + _loggedUserService.GetLastName();
            int id_room = Int32.Parse(RoomIdLabel.Text);

            DateTime time = DateTime.Now;

            if (message == "") notification.GetNotification("Error", "Enter some message!");
            else
            {
                uc_chatService.SavingMessagesToDatbase(message, time, id_room);
                uc_chatService.CreatingChatMessage(this, message, time, false, user_fullName);
                MessageFieldTBox.Text = "";
            }
        }

        private void UC_Chat_Load(object sender, EventArgs e)
        {
            uc_chatService.AutomaticChatScroll(this);
            RoomIdLabel.Text = id.ToString();
            RoomNameLabel.Text = name_room;

            uc_chatService.GeneratingAllMessages(this, id);
        }

    }
}
