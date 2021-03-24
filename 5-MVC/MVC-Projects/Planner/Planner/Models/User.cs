using System.ComponentModel.DataAnnotations;

namespace Planner.Models
{
    public class User
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Input username")]
        [StringLength(5,ErrorMessage = "username is not correct")]

        public string UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Input password")]
        [StringLength(5, ErrorMessage = "password is not correct")]
        public string Password { get; set; }

    }
}
