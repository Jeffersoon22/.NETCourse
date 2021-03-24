using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentals.Models;
using CarRentals.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace CarRentals.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ILogger _logger;

        public CarController(ICarService carService)
        {
            _carService = carService;
            _logger = LogManager.GetCurrentClassLogger();
        }
        // GET: Car
        public ActionResult Index()
        {
            _logger.Info("Car Index invoked");
            var cars = _carService.GetCars();
            return View(cars);
        }

        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            _logger.Info("Car Details invoked");
            var car = _carService.GetCars().SingleOrDefault(x => x.Id == id);
            return View(car);
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            _logger.Info("Car Create invoked");
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            try
            {
                // TODO: Add insert logic here
                _carService.AddCar(car);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {

                _logger.Error(ex, "Error while creating the car");
                return View();
            }
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            _logger.Info("Car Edit invoked");
            var car = _carService.GetCars().SingleOrDefault(x => x.Id == id);
            return View(car);
        }

        // POST: Car/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Car car)
        {
            try
            {
                _carService.UpdateCar(car);
                _logger.Info("Car Updated");
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                _logger.Error(ex, "Error while creating the car");
                return View();
            }
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int id)
        {
            _carService.DeleteCar(id);
            _logger.Info("Car Deleted");
            return RedirectToAction("Index");
        }

    }
}