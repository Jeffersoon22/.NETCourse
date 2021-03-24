using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Models
{
    public class Student
    {

        [MinLength(3, ErrorMessage = "No less than 3 characters")]
        [MaxLength(31, ErrorMessage = "No more than 30 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = " Required")]
        [RegularExpression(@"^[A-Z][a-z]*", ErrorMessage = "Start with upeercase")]
        public string FirstName { get; set; }

        [MinLength(3, ErrorMessage = "Min 3 characters")]
        [MaxLength(31, ErrorMessage = "Max 30 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = " Required")]
        [RegularExpression(@"^[A-Z][a-z]*", ErrorMessage = "Start with upercase")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please input birtday")]
        public DateTime BirthDate { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Required!!! Input course")]
        public Decimal Course { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Input valid email.")]
        public string Email { get; set; }


        [MaxLength(30, ErrorMessage = "Max 30 characters")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,12}$", ErrorMessage = "Should contains:\n1 integer type,\nMin 6 characters!\nmin 1 upper case,\nmin1 lower case,\nmin 1 special symbol")]

        public string Password { get; set; }

        //[Required(AllowEmptyStrings = false,ErrorMessage ="Agree terms and polices")]
        public bool Agree { get; set; }
    }
}
