using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_1.Logger;
using Practice_1.Models;
using Practice_1.Services;

namespace Practice_1.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IAccount _account;
        private readonly IAccountLogger _logger;


        public HomeController(IAccountLogger logger,IAccount account)
        {
            _account = account;
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInfo("Hello from Account Index method");
            ViewBag.questions = AccountInfo.Questions;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            _logger.LogInfo("Hello from create method");
            return View("Success");
        }


        [HttpPost]
        public IActionResult Login(string UserName,string Password)
        {
            
            var accounts = _account.GetAllAccounts();
            try
            {
                _logger.LogError();
                if (accounts.FirstOrDefault(x => x.UserName == UserName).Password == Password)
                {
                    _logger.LogInfo($"Hello {UserName}");
                    return View("Loggedin");
                }
                ViewBag.questions = AccountInfo.Questions;

                return View("Index");
                
            }
            catch
            {
                _logger.LogError("Account doesnt exist");
                ViewBag.questions = AccountInfo.Questions;

                return View("Index");

            }

        }
        [HttpGet]
        public IActionResult Login()
        {
                return View();
        }
        [HttpPost]
        public IActionResult Create(AccountInfo account)
        {
            Random rand = new Random();
            int id = rand.Next(10, 1000);
            account.ClientId = id;
            _account.AddAccount(account);
            return View("Success",account);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
