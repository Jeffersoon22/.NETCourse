using System;
using System.Collections.Generic;

namespace Tutorials.Models
{
    public partial class Warehouse
    {
        public int Id { get; set; }
        public int? BookId { get; set; }
        public int? Count { get; set; }

        public virtual Book Book { get; set; }
    }
}
