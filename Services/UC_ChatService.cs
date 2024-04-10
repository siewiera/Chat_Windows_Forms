using Chat.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = Chat.Entities.Message;

namespace Chat.Services
{
    
    internal class UC_ChatService 
    {
        
        private LoggedUserService _loggedUserService;
        /*private readonly ChatDbContext dbContext;*/

        public UC_ChatService()
        {
           /* dbContext = new ChatDbContext();*/
            int idLoggedUser = GlobalVariables.Instance.globalId;
            if (idLoggedUser == null || idLoggedUser == 0) idLoggedUser = 14;

            _loggedUserService = new LoggedUserService(idLoggedUser);
        }

        public void CreatingChatMessage(UC_Chat uc_chat, string message, DateTime nowDate, bool otherMessage, string user_fullName)
        {
            FlowLayoutPanel myMessageAreaLPanel = new FlowLayoutPanel();

            Label label_message = new Label();
            Label label_detials = new Label();

            /*string user_fullName = _loggedUserService.GetName() + ' ' + _loggedUserService.GetLastName();*/
            /*DateTime now = DateTime.Now;
            string nowDate = now.ToString("HH:mm:ss dd.MM.yyyy");*/

            var rightToLeft = System.Windows.Forms.RightToLeft.Yes;
            var backColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            var textAlign = System.Drawing.ContentAlignment.MiddleRight;

            if (otherMessage)
            {
                rightToLeft = System.Windows.Forms.RightToLeft.No;
                backColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                textAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }


            /* message container */
            label_message.AutoSize = true;
            label_message.BackColor = backColor;
            label_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            myMessageAreaLPanel.SetFlowBreak(label_message, true);
            label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            label_message.ForeColor = System.Drawing.Color.Black;
            label_message.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label_message.Location = new System.Drawing.Point(320, 18);
            label_message.Margin = new System.Windows.Forms.Padding(5);
            label_message.MinimumSize = new System.Drawing.Size(20, 20);
            label_message.MaximumSize = new System.Drawing.Size(710, 99950);
            label_message.Name = "MyMessageLabel";
            label_message.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label_message.AutoSize = true;
            label_message.TabIndex = 2;
            label_message.Text = message;
            label_message.TextAlign = textAlign;

            /* message details */
            label_detials.AutoSize = true;
            label_detials.ForeColor = System.Drawing.Color.White;
            label_detials.Location = new System.Drawing.Point(437, 0);
            label_detials.Name = "MyNicknameAndTimeLabel";
            label_detials.Size = new System.Drawing.Size(85, 13);
            label_detials.TabIndex = 3;
            label_detials.Text = user_fullName + " " + nowDate.ToString();


            /* area for message */
            myMessageAreaLPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            myMessageAreaLPanel.BackColor = System.Drawing.Color.Transparent;
            myMessageAreaLPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            myMessageAreaLPanel.Controls.Add(label_detials);
            myMessageAreaLPanel.Controls.Add(label_message);
            uc_chat.ChatBoxLayoutPanel.SetFlowBreak(myMessageAreaLPanel, true);
            myMessageAreaLPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            myMessageAreaLPanel.Location = new System.Drawing.Point(8, 8);
            myMessageAreaLPanel.Name = "MyMessageAreaLPanel";
            /*myMessageAreaLPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;*/
            myMessageAreaLPanel.RightToLeft = rightToLeft;
            myMessageAreaLPanel.MaximumSize = new System.Drawing.Size(735, 99999);
            myMessageAreaLPanel.MinimumSize = new System.Drawing.Size(735, 61);
            myMessageAreaLPanel.AutoSize = true;
            myMessageAreaLPanel.TabIndex = 6;

            uc_chat.ChatBoxLayoutPanel.Controls.Add(myMessageAreaLPanel);
            AutomaticChatScroll(uc_chat);
        }

        public void AutomaticChatScroll(UC_Chat uc_chat)
        {
            uc_chat.ChatBoxLayoutPanel.AutoScrollPosition = new System.Drawing.Point(0, uc_chat.ChatBoxLayoutPanel.VerticalScroll.Maximum);
        }

        public void SavingMessagesToDatbase(string message, DateTime time, int id_room)
        {
            int id_user = GlobalVariables.Instance.globalId;
            if (id_user == null || id_user == 0) id_user = 15;

            var conversation = new Conversation()
            {
                ConversationUser =new ConversationUser()
                {
                    UserId = id_user,
                },
                RoomId = id_room,
                Message = new Message()
                {
                    Contents =  message,
                    CreationDate = time,
                    
                },
            };

            using (var dbContext = new ChatDbContext())
            {
                dbContext.Conversations.Add(conversation);
                dbContext.SaveChanges();
            }
        }
        private class Messages
        {
            public int id_user;
            public string nickname;
            public DateTime messageDate;
            public string contents;
        };

        private List<Messages> GetAllMessage(int id_room)
        {
            using (var dbContext = new ChatDbContext())
            {
                var query = (from con in dbContext.Conversations
                             join cu in dbContext.ConversationUsers on con.ConversationUserId equals cu.Id
                             join us in dbContext.Users on cu.UserId equals us.Id
                             join ro in dbContext.Rooms on con.RoomId equals ro.Id
                             join me in dbContext.Messages on con.MessageId equals me.Id
                             where ro.Id == id_room
                             orderby con.Id
                             select new Messages
                             {
                                 id_user = us.Id,
                                 nickname = us.NickName,
                                 messageDate = me.CreationDate,
                                 contents = me.Contents
                             })
                             .ToList();

                return query;
            }
        }

        public void GeneratingAllMessages(UC_Chat uc_chat, int id_room)
        {
            var messageDetails = GetAllMessage(id_room);
            int id_logged = GlobalVariables.Instance.globalId;

            foreach (var detail in messageDetails)
            {
                if(id_logged == detail.id_user)
                    CreatingChatMessage(uc_chat, detail.contents,  detail.messageDate, false, detail.nickname);
                else
                    CreatingChatMessage(uc_chat, detail.contents, detail.messageDate, true, detail.nickname);
            }
        }
    }
}
