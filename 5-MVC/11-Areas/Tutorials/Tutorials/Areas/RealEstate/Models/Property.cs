using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials.Models
{
    public class Property
    {
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        [Display(Name = "Estate name")]
        public string Name { get; set; }
        public int  Square { get; set; }
        public string Address { get; set; }
    }
}
