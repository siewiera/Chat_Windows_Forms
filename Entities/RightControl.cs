using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class RightControl
    {
        public int Id { get; set; }

        public int RightId { get; set; }
        public virtual Right Right { get; set; }

        public int ControlId { get; set; }
        public virtual ControlForm ControlForm { get; set; }
    }
}
