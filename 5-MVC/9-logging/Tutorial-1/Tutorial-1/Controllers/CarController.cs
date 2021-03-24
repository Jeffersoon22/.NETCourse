using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tutorial_1.Logger;
using Tutorial_1.Models;
using Tutorial_1.Services;

namespace Tutorial_1.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        private readonly ICarLogger _logger;

        public CarController(ICarService carService, ICarLogger logger)
        {
            _carService = carService;
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.LogInfo("Hello from CarController Index method");
            //throw new ExecutionEngineException("Play with Exceptions");
            var cars = _carService.GetAllCars();
            return View(cars);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            _logger.LogInfo("Hello from create method");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car) 
        {
            _logger.LogInfo($"Car {car.Name} was created; max speed= {car.MaxSpeed}");
            if (car.MaxSpeed==111)
            {
                var ex =  new FormatException("Error on purpose");
                _logger.LogError(ex, "Logging exception on purpose");
                throw ex;
            }
            _carService.AddCar(car);
            return RedirectToAction("Index");
        }


    }
}