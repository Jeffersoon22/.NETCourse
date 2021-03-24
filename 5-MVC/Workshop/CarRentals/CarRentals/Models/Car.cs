using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [Display(Name="Top Speed")]
        [Range(10,390)]
        public int MaxSpeed { get; set; }
        [Required]
        [Range(0,99999)]
        public int Milage { get; set; }

    }
}
