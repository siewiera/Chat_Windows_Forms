using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class Right
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<RightRole> RightRoles { get; set; }
    }
}
