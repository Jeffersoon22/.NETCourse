using GamesStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace tutorial_1.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Game newGame)
        {
            if (ModelState.IsValid)
            {
                return View("Created", newGame);
            }
            return View();
        }
        public IActionResult Created()
        {
            var game = new Game();
            return View(game);
        }
    }
}





