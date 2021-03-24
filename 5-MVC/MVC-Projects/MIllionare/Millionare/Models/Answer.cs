using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Models
{
    public class Answer
    {
        //[Required]
        //[MinLength(7,ErrorMessage = "Answer length should be more than 7 characters.")]
        public string AnswerContent { get; set; }
        //[Required]
        public bool IsRight { get; set; }

        public char AnswerChar { get; set; }


    }
}
