using System;
using System.Collections.Generic;

namespace Tutorials.Models
{
    public partial class Bookpicking
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? StudentId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Student Student { get; set; }
    }
}
