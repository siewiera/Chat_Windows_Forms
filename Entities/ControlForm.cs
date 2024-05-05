using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Entities
{
    internal class ControlForm
    {
        public int Id { get; set; }
        public int TabIndex { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ControlType { get; set; }
        public string FormName { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<RightControl> RightControls { get; set; }
    }
}
