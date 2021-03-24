using System;
using System.Collections.Generic;

namespace Tutorials.Models
{
    public partial class Author
    {
        public Author()
        {
            BookAuthor = new HashSet<BookAuthor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
    }
}
