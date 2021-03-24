using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practices
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
