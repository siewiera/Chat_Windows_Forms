using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IdentityModel.Claims;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class Role
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<RightRole> RightRoles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
