using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Tutorals.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        //private readonly RoleManager<IdentityUser<int>> _roleManager;
        public AccountController(
            UserManager<IdentityUser<int>> userManager,
            SignInManager<IdentityUser<int>> signInManager)
            //RoleManager<IdentityUser<int>> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            //_roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult>Register(string username, string password)
        {
            var user = new IdentityUser<int> { UserName = username };
            IdentityResult result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                var createdUser = await _userManager.FindByNameAsync(username);
                var role = username.Contains("admin") ? "Admin" : "User";

                await _userManager.AddToRoleAsync(createdUser, role);
                await _userManager.AddClaimAsync(createdUser, new Claim(ClaimTypes.Name, username));
            }
            ModelState.AddModelError("Register error", string.Join(", ", result.Errors));

            return result.Succeeded
                ? RedirectToAction("Index", "Home")
                : RedirectToAction("Register", "Account");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(string username , string password)
        {
            var result = Microsoft.AspNetCore.Identity.SignInResult.NotAllowed;
            var user = await _userManager.FindByNameAsync(username);

            if (user !=null)
            {
                result = await _signInManager.PasswordSignInAsync(user, password, false, false);
            }

            if (result.IsNotAllowed)
            {
                ModelState.AddModelError("Login Error", "Not allowed");
            }

            return result.Succeeded
                ? RedirectToAction("Index", "Home")
                : RedirectToAction("Login", "Accoubt");
            {

            }
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}