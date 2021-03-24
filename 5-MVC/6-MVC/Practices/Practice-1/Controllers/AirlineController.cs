using Microsoft.AspNetCore.Mvc;
using Practice_1.Model;
using Practice_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Practice_1.Controllers
{
    public class AirlineController : Controller
    {
        private readonly IAirlineService _airlineService;

        public AirlineController(IAirlineService airlineService)
        {
            _airlineService = airlineService;

        }
        public IActionResult GetAllAirlines()
        {
        var airlines = _airlineService.GetAllAirlines();
        return View(airlines);
        }

        public IActionResult CreateNewAirline(string AirlineName, int AircraftCount, bool IsLowcost, int MaximumLuggageWeight)
        {
            var airline = new Airline(AirlineName, AircraftCount, IsLowcost, MaximumLuggageWeight);
            _airlineService.AddAirline(airline);
            var airlines = _airlineService.GetAllAirlines();
            return View("GetAllAirlines", airlines);

        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
