using Planner.Models;
using Planner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planner.Services
{
    public class EventPlanningService : IEventPlanningService
    {
        private readonly IRepository<EventPlanning> _planRepository;


        public EventPlanningService(IRepository<EventPlanning> planRepository)
        {
            _planRepository = planRepository;
        }

        public void AddEvent(EventPlanning plan)
        {
            _planRepository.Add(plan);
        }

        public void DeleteEvent(int id)
        {
            _planRepository.Delete(id);
        }

        public IEnumerable<EventPlanning> GetEvents()
        {
            return _planRepository.GetAll();
        }

        public void UpdateEvent(EventPlanning plan)
        {
            _planRepository.Update(plan);
        }
    }
}
