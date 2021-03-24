using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Position Position { get; set; } = new Position() { Name = "Freelancer", Salary = 1000000 };
    }
}
