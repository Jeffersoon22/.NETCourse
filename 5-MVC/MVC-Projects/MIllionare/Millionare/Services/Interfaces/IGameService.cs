using Millionare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Millionare.Services.Interfaces
{
    public interface IGameService
    {
        public int QuestionIndex { get; set; }
        public int MoneyWon { get; set; }

        public List<string> Tips { get; set; }

        public void TakeMoney();
        public Question FiftyFifty(Question question);
        public string AskTheAudience(Question question);
        public string PhoneAFriend(Question question);

        public Question PresentQuestion { get; set; }
        public History PresentHistory { get; set; }
    }
}
