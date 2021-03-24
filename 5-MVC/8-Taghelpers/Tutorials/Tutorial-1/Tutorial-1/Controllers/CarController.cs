using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tutorial_1.Models;
using Tutorial_1.Services;

namespace Tutorial_1.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        public IActionResult Index()
        {
            var cars = _carService.GetAllCars();
            return View(cars);
        }

        [HttpGet]
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car) {
            _carService.AddCar(car);
            return RedirectToAction("Index");
        }


    }
}