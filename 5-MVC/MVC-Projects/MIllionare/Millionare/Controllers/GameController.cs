using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Millionare.Models;
using Millionare.Services;
using Millionare.Services.Interfaces;

namespace Millionare.Controllers
{
    public class GameController : Controller
    {
        private readonly IRepository<Question> _repository;
        private readonly IGameService _gameService;
        private readonly IRepository<History> _history;

        public GameController(IRepository<Question> repository, IGameService gameService, IRepository<History> history)
        {
            _repository = repository;
            _gameService = gameService;
            _history = history;
        }
        // GET: Game
        public ActionResult Game()
        {
            _gameService.PresentHistory = new History() { StartGameTime = DateTime.Now, MoneyWon = 0, QuestionsAnswered = 0 };
            _gameService.Tips = new List<string>() { "FiftyFifty", "PhoneAFriend", "AskTheAudience" };
            _gameService.QuestionIndex = 0;
            var question = _repository.GetAll().ElementAt(_gameService.QuestionIndex);
            _gameService.PresentQuestion = question;
            ViewBag.tips = _gameService.Tips;
            _gameService.PresentHistory =  new History() { StartGameTime = DateTime.Now, MoneyWon = 0, QuestionsAnswered = 0};
            return View(question);
        }

        [HttpPost]
        public ActionResult Game(string answer)
        {
            var question = _repository.GetAll().ElementAt(_gameService.QuestionIndex);
            var correctAnswer = question.Answers.FirstOrDefault(x => x.IsRight == true).AnswerContent;


            if (correctAnswer==answer)
            {
                _gameService.MoneyWon = _repository.GetAll().ElementAt(_gameService.QuestionIndex).Cost;
                _gameService.PresentHistory.MoneyWon = _gameService.MoneyWon;
                _gameService.PresentHistory.QuestionsAnswered++;

                if(_gameService.QuestionIndex == 2)
                {
                    _gameService.Tips.Add("TakeMoney");
                }



                if (_gameService.QuestionIndex==_repository.GetAll().Count()-1)
                {
                    _history.Add(_gameService.PresentHistory);
                    return View("Win",_gameService.MoneyWon);
                }
                _gameService.QuestionIndex++;
                var newQuestion = _repository.GetAll().ElementAt(_gameService.QuestionIndex);
                _gameService.PresentQuestion = newQuestion;
                ViewBag.tips = _gameService.Tips;
                return View(newQuestion);
            }
            else
            {
                _gameService.MoneyWon = 0;
                _gameService.PresentHistory.MoneyWon = _gameService.MoneyWon;
                _history.Add(_gameService.PresentHistory);

                return View("GameOver");
            }

            

        }


        [HttpPost]
        public ActionResult AskTheAudience()
        {
            ViewBag.TipResponse= _gameService.AskTheAudience(_gameService.PresentQuestion);
            ViewBag.tips = _gameService.Tips;
            _gameService.Tips.Remove("AskTheAudience");
            return View("Game",_gameService.PresentQuestion);

        }

        [HttpPost]
        public ActionResult PhoneAFriend()
        {
            ViewBag.TipResponse = _gameService.PhoneAFriend(_gameService.PresentQuestion);
            ViewBag.tips = _gameService.Tips;
            _gameService.Tips.Remove("PhoneAFriend");
            return View("Game", _gameService.PresentQuestion);

        }


        [HttpPost]
        public ActionResult FiftyFifty()
        {
            _gameService.PresentQuestion = _gameService.FiftyFifty(_gameService.PresentQuestion);
            ViewBag.tips = _gameService.Tips;
            _gameService.Tips.Remove("FiftyFifty");
            return View("Game", _gameService.PresentQuestion);

        }

        public ActionResult History()
        {
            return View(_history.GetAll());
        }

        [HttpPost]
        public ActionResult TakeMoney()
        {
            ViewBag.tips = _gameService.Tips;
            _gameService.Tips.Remove("TakeMoney");
            _history.Add(_gameService.PresentHistory);
            return View("Win", _gameService.MoneyWon);

        }

    }
}