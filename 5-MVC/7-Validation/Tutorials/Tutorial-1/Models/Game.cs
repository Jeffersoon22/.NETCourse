using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GamesStore.Models
{
    public class Game
    {
        [Required(AllowEmptyStrings =false, ErrorMessage ="Name cannot be empty")]
        [MinLength(3,ErrorMessage ="Not less than 3 characters")]
        [MaxLength(60, ErrorMessage ="Not more than 60 characters")]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(30,ErrorMessage ="No more than 30 characters")]
        [RegularExpression(@"^[A-Z][a-z]*$")]
        public string Genre { get; set; }
        [Required]
        [MaxLength(5,ErrorMessage ="Not more than 5 chars")]
        [RegularExpression(@"^[A-Z][a-z]*$")]
        public double Rating { get; set; }


    }
}
