using System;
using System.Collections.Generic;

namespace Tutorials.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            Student = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
