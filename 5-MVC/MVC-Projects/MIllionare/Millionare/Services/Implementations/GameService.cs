using Millionare.Models;
using Millionare.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Services.Implementations
{
    public class GameService :IGameService
    {
        public int QuestionIndex { get; set; }
        public int MoneyWon { get; set; }
        public List<string> Tips { get; set; }
        public Question PresentQuestion { get ; set; }

        public History PresentHistory { get; set; }

        public string AskTheAudience(Question question)
        {
            Random audience = new Random();
            int rand = audience.Next(0, 100);
            char result = default;
            if(rand < 85)
            {
                result = question.Answers.FirstOrDefault(x=>x.IsRight==true).AnswerChar;

            }
            else
            {
                while (true)
                {
                    int newansw = audience.Next(0, question.Answers.Count());
                    if (question.Answers.ElementAt(newansw).IsRight!=true)
                    {
                        result = question.Answers.ElementAt(newansw).AnswerChar;
                        break;
                    }
                }

            }
            return $"Audience: correct answer is { result }";

        }

        public Question FiftyFifty(Question question)
        {
            var result = new Question()
            {
                Cost = question.Cost,
                QuestionContent = question.QuestionContent,
                Id = question.Id,
                Answers = new List<Answer>()

            };


            foreach (var item in question.Answers)
            {
                result.Answers.Add(new Answer()
                {
                    AnswerChar = item.AnswerChar,
                    AnswerContent = item.AnswerContent,
                    IsRight = item.IsRight
                });
            }

            

            Random rand = new Random();
            int count = 0;
            while (count != 2)
            {
                
                int randindex = rand.Next(0, result.Answers.Count());
                if (result.Answers[randindex].IsRight != true)
                {
                    result.Answers.RemoveAt(randindex);
                    count++;
                }
                
            }
            return result;
        }

            public string PhoneAFriend(Question question)
        {
            Random friend = new Random();
            int rand = friend.Next(0, question.Answers.Count());
            char result = default;
            while (true)
            {
                result = question.Answers.ElementAt(rand).AnswerChar;
                if (question.Answers.ElementAt(rand) != null)
                {
                    result = question.Answers.ElementAt(rand).AnswerChar;
                    break;
                } 
            }
            return $"Alex, your friend: I don't know maybe... {result}";
        }

        public void TakeMoney()
        {
            throw new NotImplementedException();
        }
    }
}
