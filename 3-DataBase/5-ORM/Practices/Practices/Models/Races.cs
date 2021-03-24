using System;
using System.Collections.Generic;

namespace Practices.Models
{
    public partial class Races
    {
        public Races()
        {
            RaceParticipations = new HashSet<RaceParticipations>();
        }

        public int RaceId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public string Place { get; set; }

        public virtual ICollection<RaceParticipations> RaceParticipations { get; set; }
    }
}
