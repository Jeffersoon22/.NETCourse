using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice_1.Models;

namespace Practice_1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student,bool agree)
        {
            if (ModelState.IsValid && agree==true)
            {
                return View("Created", new List<Student> {student});
            }
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        


    }
}