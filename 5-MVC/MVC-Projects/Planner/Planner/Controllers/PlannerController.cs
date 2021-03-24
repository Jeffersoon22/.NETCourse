using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NLog;
using Planner.Helpers;
using Planner.Models;
using Planner.Services;

namespace Planner.Controllers
{
    public class PlannerController : Controller
    {
        private readonly IEventPlanningService _eventPlanningService;
        private readonly NLog.ILogger _logger;

        public PlannerController(IEventPlanningService eventPlanning)
        {
            _eventPlanningService = eventPlanning;
            _logger = LogManager.GetCurrentClassLogger();
        }
        public IActionResult Index()
        {
            var plans = _eventPlanningService.GetEvents();
            return View(plans);
        }


        public ActionResult Create()
        {
            _logger.Info("Event Create invoked");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventPlanning plan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (plan.StartDateTime < plan.EndDateTime)
                    {
                        _eventPlanningService.AddEvent(plan);
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    return View();
                } 
            }
            catch (Exception ex)
            {

                _logger.Error(ex, "Error while creating the event");
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            _logger.Info("event Edit invoked");
            var plan = _eventPlanningService.GetEvents().SingleOrDefault(x => x.Id == id);
            return View(plan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EventPlanning plan)
        {
            try
            {
                if (plan.StartDateTime < plan.EndDateTime)
                {
                    _eventPlanningService.UpdateEvent(plan);
                    _logger.Info("event Updated");
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    _logger.Info("Error while editing the event");
                    return View();
                }
                
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error while creating the event");
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            _eventPlanningService.DeleteEvent(id);
            _logger.Info("event Deleted");
            return RedirectToAction("Index");
        }


        [HttpPost]
        
        public ActionResult FuturePlans(DateTime date)
        {
            var plans = _eventPlanningService.GetEvents().Where(x => x.StartDateTime.ToLongDateString() == date.ToLongDateString()).OrderBy(x => x.StartDateTime);
            return View(plans);
        }

        public ActionResult Search()
        {
            return View();
        }


    }
}