using System;
using System.Collections.Generic;

namespace Practices.Models
{
    public partial class RaceParticipations
    {
        public int RaceId { get; set; }
        public int HorseId { get; set; }
        public int JockeyId { get; set; }
        public int Place { get; set; }
        public int ShownTime { get; set; }
        public int Id { get; set; }

        public virtual Horses Horse { get; set; }
        public virtual Jockeys Jockey { get; set; }
        public virtual Races Race { get; set; }
    }
}
