using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tutorials.Models;
using Tutorials.Services;

namespace Tutorials.RealEstate.Controllers
{
    [Area("RealEstate")]
    public class RealEstateController : Controller
    {
        private readonly IRealEstateService _realEstateService;

        public RealEstateController(IRealEstateService realEstateService)
        {
            _realEstateService = realEstateService;
        }

        public IActionResult Index()
        {
            var properties = _realEstateService.GetTop3Properties();
            return View(properties);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Property property)
        {
            _realEstateService.AddProperty(property);
            return RedirectToAction("Index");
        }


    }
}