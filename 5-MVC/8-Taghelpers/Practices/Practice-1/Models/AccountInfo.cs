using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Models
{
    public class AccountInfo
    {
        public static List<string> Questions = new List<string> { "What was the name of your first pet ?",
            "What is your favorite color?",
            "What town were you born in?",
            "What is your mother's maiden name?" };
        public int ClientId;

        [Required(AllowEmptyStrings = false,ErrorMessage ="Username must be inputed")]
        [MinLength(2, ErrorMessage = "Minimum length must be 2 cahracters")]
        [MaxLength(20, ErrorMessage = "Maximum length must be 20 cahracters")]
        //unique special characters and spaces are not allowed
        [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage ="Don't use special symbols.")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password must be inputed")]
        [MinLength(6, ErrorMessage = "Minimum length must be 6 cahracters")]
        [MaxLength(12, ErrorMessage = "Maximum length must be 12 cahracters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,12}$", 
            ErrorMessage = "Password must contain at least one digit and one upper case letter, one special symbol.")]
        //must be 1 Digit one uppercase and one special symbol
        public string Password { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage = "Question must be inputed")]

        public string CodeQuestion { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Answer must be inputed")]
        [MaxLength(30)]
        public string CodeAnswear { get; set; }
    }
}
