using System;
using System.Collections.Generic;

namespace Practices.Models
{
    public partial class Horses
    {
        public Horses()
        {
            RaceParticipations = new HashSet<RaceParticipations>();
        }

        public int HorseId { get; set; }
        public string HorseName { get; set; }
        public string HorseAge { get; set; }
        public string HorseGender { get; set; }
        public int OwenerId { get; set; }

        public virtual HorseOnwers Owener { get; set; }
        public virtual ICollection<RaceParticipations> RaceParticipations { get; set; }
    }
}
