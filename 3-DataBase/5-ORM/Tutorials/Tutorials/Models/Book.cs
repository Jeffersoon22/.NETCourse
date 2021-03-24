using System;
using System.Collections.Generic;

namespace Tutorials.Models
{
    public partial class Book
    {
        public Book()
        {
            BookAuthor = new HashSet<BookAuthor>();
            Bookpicking = new HashSet<Bookpicking>();
            Warehouse = new HashSet<Warehouse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public int? Pages { get; set; }
        public int? Illustrations { get; set; }
        public int? PublisherId { get; set; }
        public int? BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
        public virtual ICollection<Bookpicking> Bookpicking { get; set; }
        public virtual ICollection<Warehouse> Warehouse { get; set; }
    }
}
