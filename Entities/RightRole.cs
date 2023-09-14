using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class RightRole
    {
        public int Id { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public int RightId { get; set; }
        public virtual Right Right { get; set; }

    }
}
