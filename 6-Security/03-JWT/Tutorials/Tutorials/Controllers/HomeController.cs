using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tutorials.Models;

namespace Tutorials.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly IUserClaimsPrincipalFactory<IdentityUser<int>> _principalFactory;
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            UserManager<IdentityUser<int>> userManager,
            IUserClaimsPrincipalFactory<IdentityUser<int>> principalFactory,
            ILogger<HomeController> logger)
        {
            _userManager = userManager;
            _principalFactory = principalFactory;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult ExternalLogin(string provider)
        {
            var properties = new AuthenticationProperties 
            { 
                RedirectUri = Url.Action("ExternalLoginCallback"),
                Items = { { "scheme", provider } }
            };

            return Challenge(properties, provider);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback()
        {
            var result = await HttpContext.AuthenticateAsync(IdentityConstants.ExternalScheme);
            var externalUserId = result.Principal.FindFirstValue("sub")
                ?? result.Principal.FindFirstValue(ClaimTypes.NameIdentifier)
                ?? throw new Exception("Could not find external user");

            var provider = result.Properties.Items["scheme"];

            var user = await _userManager.FindByLoginAsync(provider, externalUserId);

            if(user == null)
            {
                var email = result.Principal.FindFirstValue("email")
                    ?? result.Principal.FindFirstValue(ClaimTypes.Email);

                if(email != null)
                {
                    user = await _userManager.FindByEmailAsync(email);

                    if(user == null)
                    {
                        user = new IdentityUser<int> { Email = email, UserName = email };
                        await _userManager.CreateAsync(user);
                    }

                    await _userManager.AddLoginAsync(user,
                        new UserLoginInfo(provider, externalUserId, provider));
                }
            }

            if (user == null) return BadRequest();

            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            var claimsPrincipal = await _principalFactory.CreateAsync(user);
            await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, claimsPrincipal);

            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
