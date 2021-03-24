using System;
using System.Collections.Generic;

namespace Practices.Models
{
    public partial class Jockeys
    {
        public Jockeys()
        {
            RaceParticipations = new HashSet<RaceParticipations>();
        }

        public int JockeyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int Rating { get; set; }

        public virtual ICollection<RaceParticipations> RaceParticipations { get; set; }
    }
}
