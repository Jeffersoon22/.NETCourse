using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Models
{
    public class Question
    {
        public int Id { get; set; }

        //[Required]
        //[MinLength(25,ErrorMessage = "Question length should be more than 25 characters.")]
        public string QuestionContent { get; set; }

        public List<Answer> Answers { get; set; }

        public int Cost { get; set; }


    }
}
