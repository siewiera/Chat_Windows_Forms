﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class Conversation
    {
        public int Id { get; set; }
        public string KeyConversation { get; set; } = new Room().KeyRoom;

        public int ConversationUserId { get; set; }
        public virtual ICollection<ConversationUser> ConversationUsers { get; set; }

        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        public int MessageId { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
