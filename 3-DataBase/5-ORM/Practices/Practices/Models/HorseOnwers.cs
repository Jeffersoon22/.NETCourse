using System;
using System.Collections.Generic;

namespace Practices.Models
{
    public partial class HorseOnwers
    {
        public HorseOnwers()
        {
            Horses = new HashSet<Horses>();
        }

        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Horses> Horses { get; set; }
    }
}
