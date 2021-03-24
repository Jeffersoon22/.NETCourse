using Planner.Models;
using System.Collections.Generic;

namespace Planner.Services
{
    public interface IEventPlanningService
    {
        IEnumerable<EventPlanning> GetEvents();
        void AddEvent(EventPlanning plan);
        void UpdateEvent(EventPlanning plan);
        void DeleteEvent(int id);
    }
}
