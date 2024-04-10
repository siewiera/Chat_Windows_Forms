using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class Message
    {
        public int Id { get; set; }
        public string Contents { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual ICollection<Conversation> Conversations { get; set; }
    }
}
