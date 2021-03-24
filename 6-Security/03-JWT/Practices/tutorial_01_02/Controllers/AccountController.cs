using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practices.Data;
using Practices.Services.Interfaces;

namespace Practices.Controllers
{
   
   
    public class AccountController : Controller
    {
        private readonly IUserService userService;
        private readonly ISecurityService securityService;
        private readonly JwtDbContext context;

        public AccountController(IUserService userService, ISecurityService securityService, JwtDbContext context)
        {
            this.userService = userService;
            this.securityService = securityService;
            this.context = context;
        }

        [HttpPost]
        [Route("token")]
        public IActionResult Token(string username, string password)
        {
            var user = userService.GetUserByName(username);
            if (user!=null && securityService.VerifyUserPassword(user, password) && !user.IsBlocked)
            {
                context.Users.Find(user.Id).InvalidLoginAttemptsAmount = 0;
                context.SaveChanges();
                var result= securityService.IssueJwtToken(user);
                return Json(result);
            }
            else if (user != null)
            {
                context.Users.Find(user.Id).InvalidLoginAttemptsAmount += 1;
                if (context.Users.Find(user.Id).InvalidLoginAttemptsAmount >= 5)
                {
                    context.Users.Find(user.Id).IsBlocked = true;
                }
                context.SaveChanges();
            }
            return BadRequest();
        }

    }
}