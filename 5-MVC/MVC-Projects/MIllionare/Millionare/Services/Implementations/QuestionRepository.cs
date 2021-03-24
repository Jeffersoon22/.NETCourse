using Millionare.Models;
using Millionare.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Services
{
    public class QuestionRepository : IRepository<Question>
    {

        private List<Question> _questions = new List<Question>
        {
            new Question
            {
                Cost=7000,
                Id=1,
                QuestionContent="Which of these US presidents appeared on the television series 'Laugh-In'?",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        AnswerChar='A',
                        AnswerContent="Lyndon Johnson",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='B',
                        AnswerContent="Richard Nixon",
                        IsRight=true
                    },
                    new Answer
                    {
                        AnswerChar='C',
                        AnswerContent="Jimmy Carter",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='D',
                        AnswerContent="Gerald Ford",
                        IsRight=false
                    },
                }
            },

            new Question
            {
                Cost=12000,
                Id=2,
                QuestionContent="The Earth is approximately how many miles away from the Sun?",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        AnswerChar='A',
                        AnswerContent="9.3 million",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='B',
                        AnswerContent="39 million",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='C',
                        AnswerContent="93 million",
                        IsRight=true
                    },
                    new Answer
                    {
                        AnswerChar='D',
                        AnswerContent="193 million",
                        IsRight=false
                    },
                }
            },

            new Question
            {
                Cost=70000,
                Id=3,
                QuestionContent="Which insect shorted out an early supercomputer and inspired the term “computer bug?”",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        AnswerChar='A',
                        AnswerContent="Moth",
                        IsRight=true
                    },
                    new Answer
                    {
                        AnswerChar='B',
                        AnswerContent="Roach",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='C',
                        AnswerContent="Fly",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='D',
                        AnswerContent="Japanese beetle",
                        IsRight=false
                    },
                }
            },

            new Question
            {
                Cost=120000,
                Id=4,
                QuestionContent="Which of the following men does not have a chemical element named for him?",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        AnswerChar='A',
                        AnswerContent="Albert Einstein",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='B',
                        AnswerContent="Niels Bohr",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='C',
                        AnswerContent="Isaac Newton",
                        IsRight=true
                    },
                    new Answer
                    {
                        AnswerChar='D',
                        AnswerContent="Enrico Fermi",
                        IsRight=false
                    },
                }
            },

            new Question
            {
                Cost=700000,
                Id=5,
                QuestionContent="Which of the following landlocked countries is entirely contained within another country?",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        AnswerChar='A',
                        AnswerContent="Lesotho",
                        IsRight=true
                    },
                    new Answer
                    {
                        AnswerChar='B',
                        AnswerContent="Burkina Faso",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='C',
                        AnswerContent="Mongolia",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='D',
                        AnswerContent="Luxembourg",
                        IsRight=false
                    },
                }
            },

            new Question
            {
                Cost=1000000,
                Id=6,
                QuestionContent="In the children’s book series, where is Paddington Bear originally from?",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        AnswerChar='A',
                        AnswerContent=" India",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='B',
                        AnswerContent="Peru",
                        IsRight=true
                    },
                    new Answer
                    {
                        AnswerChar='C',
                        AnswerContent="Canada",
                        IsRight=false
                    },
                    new Answer
                    {
                        AnswerChar='D',
                        AnswerContent="Iceland",
                        IsRight=false
                    },
                }
            },
        };

        public QuestionRepository()
        {
        }

        public void Add(Question item)
        {
        }

        public IEnumerable<Question> GetAll()
        {
            return _questions;
        }

        public void Update(Question item)
        {
            var question = _questions.SingleOrDefault(x => x.Id == item.Id);

            var index = _questions.IndexOf(question);
            _questions[index].QuestionContent = item.QuestionContent;
            question.QuestionContent = item.QuestionContent;
            for (int i = 0; i < question.Answers.Count(); i++)
            {
                question.Answers[i].AnswerContent = item.Answers[i].AnswerContent;
                question.Answers[i].IsRight = item.Answers[i].IsRight;
            }
            
        }
    }
}
