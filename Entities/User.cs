using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class User
    {
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]     
        public string EmailAdress { get; set; }
        [Required]
        [MinLength(5)]
        public string Password { get; set; }
        [MinLength(3)]
        public string NickName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }       
        public bool Blocked { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public virtual ICollection<ConversationUser> ConversationUsers { get; set; }
    }
}
