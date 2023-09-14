using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class Room
    {
        public int Id { get; set; }
        [Required]
        public string KeyRoom { get; set; } = DateTime.Now.ToString("yyyyMMddHHmmss");
        public string Name { get; set; }
        public string Password { get; set; }
        [Required]
        public bool Blocked { get; set; }

        public virtual ICollection<Conversation> Conversations{ get; set; }
    }
}
