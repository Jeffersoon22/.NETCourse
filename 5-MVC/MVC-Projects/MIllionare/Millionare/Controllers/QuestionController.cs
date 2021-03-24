using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Millionare.Models;
using Millionare.Services;

namespace Millionare.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }


        // GET: Question
        public ActionResult Index()
        {
            var questions = _questionService.GetQuestions();
            return View(questions);
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            var questions = _questionService.GetQuestions().SingleOrDefault(x => x.Id == id);
            return View(questions);
        }


        // GET: Question/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Question question = _questionService.GetQuestions().Single(x => x.Id == id);
            return View(question);
        }

        // POST: Question/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Question question)
        {
            try
            {
                // TODO: Add update logic here
                _questionService.UpdateQuestion(question);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}