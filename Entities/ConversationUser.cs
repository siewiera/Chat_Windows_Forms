using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class ConversationUser
    {
        public int Id { get; set; }

        public int ConversationId { get; set; }
        public virtual List<Conversation> Conversations { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}
