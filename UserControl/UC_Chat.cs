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
using System.Timers;

namespace Chat
{
    public partial class UC_Chat : UserControl
    {
        private UC_ChatService uc_chatService = new UC_ChatService();
        private LoggedUserService _loggedUserService;
        private readonly int id;
        private readonly string name_room;
        static System.Timers.Timer timer;
        private PermissionsManagement permissionsManagement;

        public UC_Chat(int id, string name_room)
        {
            InitializeComponent();

            int idLoggedUser = GlobalVariables.Instance.globalId;
            if (idLoggedUser == null || idLoggedUser == 0) idLoggedUser = 14;

            _loggedUserService = new LoggedUserService(idLoggedUser);
            this.id = id;
            this.name_room = name_room;
        }

        public UC_Chat()
        {
            InitializeComponent();
            return;
        }

        public void SendMessageBtn_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();

            string message = MessageFieldTBox.Text;
            int id_room = Int32.Parse(RoomIdLabel.Text);

            DateTime time = DateTime.Now;

            if (message == "") notification.GetNotification("Error", "Enter some message!");
            else
            {
                uc_chatService.SavingMessagesToDatbase(message, time, id_room);
                MessageFieldTBox.Text = "";
            }
        }
        public async Task checkIsAnyNewMessage(int id_room)
        {
            await Task.Run(() =>
            {
                var allMessagesFromRoom = uc_chatService.GetAllMessage(id_room);
                int id_logged = GlobalVariables.Instance.globalId;

                foreach (var detail in allMessagesFromRoom)
                {
                    int lastConversationIdInChat = GlobalVariables.Instance.globalLastConversationId;

                    if (detail.lastConvserastionId > lastConversationIdInChat)
                    {
                        if (id_logged == detail.id_user)
                            uc_chatService.CreatingChatMessage(this, detail.contents, detail.messageDate, false, detail.nickname);
                        else
                            uc_chatService.CreatingChatMessage(this, detail.contents, detail.messageDate, true, detail.nickname);
                        GlobalVariables.Instance.globalLastConversationId = detail.lastConvserastionId;
                    }
                }
            });          
        }

        private async void UC_Chat_Load(object sender, EventArgs e)
        {


            uc_chatService.AutomaticChatScroll(this);
            RoomIdLabel.Text = id.ToString();
            RoomNameLabel.Text = name_room;

            await uc_chatService.GeneratingAllMessages(this, id);

            timer = new System.Timers.Timer(2000);
            timer.Elapsed += async (se, ev) => checkIsAnyNewMessage(id);
            timer.Start();
        }
    }
}
