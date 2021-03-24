using Planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Planner.Services.Implementations
{
    public class EventPlanningRepository:IRepository<EventPlanning>
    {
        private List<EventPlanning> _events = new List<EventPlanning>
        {
            new EventPlanning{Id=1,Name="Joe's Wedding",Author="Nato",
                StartDateTime=new DateTime(2019,12,23,3,0,0), 
                Description="Joe is to marry a consvervative daughter of a well-to-do man.",
                EndDateTime=new DateTime(2019,12,24,12,0,0),},
            new EventPlanning{Id=2,Name="Business Meeting",Author="Nato",
                StartDateTime=new DateTime(2019,12,20,15,0,0),
                Description="Business Meeting with Sandra and Kate",
                EndDateTime=new DateTime(2019,12,20,12,17,0),},
            new EventPlanning{Id=3,Name="Fabric Delivery",Author="Nato",
                StartDateTime=new DateTime(2020,01,02,10,0,0),
                Description="Delivery from shop",
                EndDateTime=new DateTime(2020,01,02,10,30,0),},
            new EventPlanning{Id=4,Name="Doctor's appointment",
                StartDateTime=new DateTime(2020,01,02,13,0,0),
                Description="dental clinic,Shota Rustaveli Avenue 14",
                EndDateTime=new DateTime(2020,01,02,15,0,0),},
        };

        public void Add(EventPlanning item)
        {
            var maxId = _events.Select(x => x.Id).Max();
            item.Id = ++maxId;
            _events.Add(item);
        }

        public void Delete(int id)
        {
            var plan = _events.SingleOrDefault(x => x.Id == id);
            _events.Remove(plan);
        }

        public IEnumerable<EventPlanning> GetAll()
        {
            return _events;
        }

        public void Update(EventPlanning item)
        {
            var plan = _events.SingleOrDefault(x => x.Id == item.Id);

            var index = _events.IndexOf(plan);
            _events[index].Name = item.Name;
            plan.Name = item.Name;
            plan.Author = item.Author;
            plan.StartDateTime = item.StartDateTime;
            plan.EndDateTime = item.EndDateTime;

        }
    }
}
