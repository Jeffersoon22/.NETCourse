using Millionare.Models;
using Millionare.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IRepository<Question> _questionRepository;

        public QuestionService(IRepository<Question> questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public IEnumerable<Question> GetQuestions()
        {
            return _questionRepository.GetAll();
        }

        public void UpdateQuestion(Question question)
        {
            _questionRepository.Update(question);
        }
    }
}
