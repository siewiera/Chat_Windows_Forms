using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.Services
{
    
    internal class UC_ChatService 
    {
        
        private LoggedUserService _loggedUserService;

        public UC_ChatService()
        {
            int idLoggedUser = GlobalVariables.Instance.globalId;
            if (idLoggedUser == null || idLoggedUser == 0) idLoggedUser = 14;
            _loggedUserService = new LoggedUserService(idLoggedUser);
        }

        public void CreatingChatMessage(string message, UC_Chat uc_chat)
        {
            FlowLayoutPanel myMessageAreaLPanel = new FlowLayoutPanel();

            Label label_message = new Label();
            Label label_detials = new Label();

            string user_fullName = _loggedUserService.GetName() + ' ' + _loggedUserService.GetLastName();
            DateTime now = DateTime.Now;
            string nowDate = now.ToString("HH:mm:ss dd.MM.yyyy");


            /* message container */
            label_message.AutoSize = true;
            label_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            label_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            myMessageAreaLPanel.SetFlowBreak(label_message, true);
            label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label_message.ForeColor = System.Drawing.Color.Black;
            label_message.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label_message.Location = new System.Drawing.Point(320, 18);
            label_message.Margin = new System.Windows.Forms.Padding(5);
            label_message.MinimumSize = new System.Drawing.Size(20, 20);
            label_message.MaximumSize = new System.Drawing.Size(480, 99950);
            label_message.Name = "MyMessageLabel5";
            label_message.RightToLeft = System.Windows.Forms.RightToLeft.No;
            /*label_message.Size = new System.Drawing.Size(200, 20);*/
            label_message.AutoSize = true;
            label_message.TabIndex = 2;
            label_message.Text = message;
            label_message.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            /* message details */
            label_detials.AutoSize = true;
            label_detials.ForeColor = System.Drawing.Color.White;
            label_detials.Location = new System.Drawing.Point(437, 0);
            label_detials.Name = "MyNicknameAndTimeLabel5";
            label_detials.Size = new System.Drawing.Size(85, 13);
            label_detials.TabIndex = 3;
            label_detials.Text = user_fullName + " " + nowDate;


            /* area for message */
            myMessageAreaLPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            myMessageAreaLPanel.BackColor = System.Drawing.Color.Transparent;
            myMessageAreaLPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            myMessageAreaLPanel.Controls.Add(label_detials);
            myMessageAreaLPanel.Controls.Add(label_message);
            uc_chat.ChatBoxLayoutPanel.SetFlowBreak(myMessageAreaLPanel, true);
            myMessageAreaLPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            myMessageAreaLPanel.Location = new System.Drawing.Point(8, 8);
            myMessageAreaLPanel.Name = "MyMessageAreaLPanel5";
            myMessageAreaLPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            myMessageAreaLPanel.MaximumSize = new System.Drawing.Size(510, 99999);
            myMessageAreaLPanel.MinimumSize = new System.Drawing.Size(510, 61);
            myMessageAreaLPanel.AutoSize = true;
            myMessageAreaLPanel.TabIndex = 6;

            uc_chat.ChatBoxLayoutPanel.Controls.Add(myMessageAreaLPanel);
        }
    }
}
