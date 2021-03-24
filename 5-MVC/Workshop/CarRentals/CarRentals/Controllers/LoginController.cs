using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentals.Helpers;
using CarRentals.Models;
using CarRentals.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentals.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthService _authService;

        public LoginController(IAuthService authService)
        {
            _authService = authService;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                if(_authService.IsUserValid(user,out string token))
                {
                    Response.Cookies.Append(Constants.tokenKey, token);
                    return Redirect(Url.Action("Index","Car"));
                }
            }
            return View("Login");
        }

    }
}