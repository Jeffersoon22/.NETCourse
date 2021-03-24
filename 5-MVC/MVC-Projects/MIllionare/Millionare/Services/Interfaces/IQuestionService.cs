using Millionare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Services
{
    public interface IQuestionService
    {
        IEnumerable<Question> GetQuestions();
        void UpdateQuestion(Question question);

    }
}
