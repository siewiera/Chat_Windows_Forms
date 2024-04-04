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

namespace Chat
{
    public partial class UC_Chat : UserControl
    {
        private UC_ChatService uc_chatService = new UC_ChatService();
        private LoggedUserService _loggedUserService;

        public UC_Chat()
        {
            InitializeComponent();
            int idLoggedUser = GlobalVariables.Instance.globalId;
            if (idLoggedUser == null || idLoggedUser == 0) idLoggedUser = 14;
            _loggedUserService = new LoggedUserService(idLoggedUser);
        }

        private void SendMessageBtn_Click(object sender, EventArgs e)
        {
            string message = MessageFieldTBox.Text;
            uc_chatService.CreatingChatMessage(message, this);
        }
    }
}
