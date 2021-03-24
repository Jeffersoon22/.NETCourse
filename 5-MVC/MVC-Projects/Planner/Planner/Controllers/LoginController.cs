using Microsoft.AspNetCore.Mvc;
using Planner.Helpers;
using Planner.Models;
using Planner.Services;
using NLog;

namespace Planner.Controllers
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
                if (_authService.IsUserValid(user, out string token))
                {
                    try
                    {
                        Response.Cookies.Append(Constants.tokenKey, token);
                        return Redirect(Url.Action("Index", "Planner"));
                    }
                    catch
                    {

                        return View("Login");
                    }
                }
                else
                {
                    return View("Login");
                }
            }
            else
            {
                return View("Login");
            }
        }

        public IActionResult Logout()
        {

            Response.Cookies.Delete(Constants.tokenKey);

            return View("Login");

        }
    }
}
