using System;
using System.Collections.Generic;

namespace Tutorials.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
