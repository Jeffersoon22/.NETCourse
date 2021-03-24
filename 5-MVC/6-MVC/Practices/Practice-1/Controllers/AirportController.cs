using Microsoft.AspNetCore.Mvc;
using Practice_1.Model;
using Practice_1.Services;
using System.Collections.Generic;
using System.Linq;

namespace Practice_1.Controllers
{
    public class AirportController : Controller
    {
        private readonly IAirportService _airportService;
        private readonly IAirlineService _airlineService;
        
        public AirportController(IAirportService airportService, IAirlineService airlineService)
        {
            _airlineService = airlineService;
            _airportService = airportService;
        }
        


        public IActionResult GetAllAirports()
        {
            var airports = _airportService.GetAirports();
            return View(airports);
        }


        public IActionResult CreateNewAirport(string name, string city, bool IsInternational,string airline)
        {
            var airport = new Airport(name,city,IsInternational) ;
            var airlines = _airlineService.Deserialize<List<Airline>>();
            var newAirline = airlines.FirstOrDefault(x=> x.AirlineName==airline);

            airport.Airlines.Add(newAirline);
            _airportService.AddAirport(airport);
            var airports = _airportService.GetAirports();
            return View("GetAllAirports", airports);
        }
         
        public IActionResult Create()
        {
            var airlines = _airlineService.Deserialize<List<Airline>>();
            ViewBag.airlines = airlines;
            return View();
        }
     }
}

