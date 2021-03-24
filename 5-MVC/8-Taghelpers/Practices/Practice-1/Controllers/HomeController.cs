using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_1.Models;
using Practice_1.Services;

namespace Practice_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccount _account;


        public HomeController(ILogger<HomeController> logger,IAccount account)
        {
            _account = account;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.questions = AccountInfo.Questions;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View("Success");
        }


        [HttpPost]
        public IActionResult Login(string UserName,string Password)
        {
            
            var accounts = _account.GetAllAccounts();
            try
            {
                if (accounts.FirstOrDefault(x => x.UserName == UserName).Password == Password)
                {
                    return View("Loggedin");
                }
                ViewBag.questions = AccountInfo.Questions;

                return View("Index");
                
            }
            catch
            {
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
