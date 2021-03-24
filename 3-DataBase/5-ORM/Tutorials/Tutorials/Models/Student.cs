using System;
using System.Collections.Generic;

namespace Tutorials.Models
{
    public partial class Student
    {
        public Student()
        {
            Bookpicking = new HashSet<Bookpicking>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Bookpicking> Bookpicking { get; set; }
    }
}
