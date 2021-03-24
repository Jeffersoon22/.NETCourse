using CarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.Services.Implementations
{
    public class CarRepository : IRepository<Car>
    {
        private List<Car> _cars = new List<Car>
        {
            new Car { Id=1,Name="BMW M3",MaxSpeed=320,Milage=1003},
            new Car { Id=2,Name="ford beetle",MaxSpeed=200,Milage=103},
            new Car { Id=3,Name="Cherry Amulet",MaxSpeed=90,Milage=0},
        };
        public void Add(Car item)
        {
            var maxId = _cars.Select(x => x.Id).Max();
            item.Id = ++maxId;
            _cars.Add(item);
        }

        public void Delete(int id)
        {
            var car = _cars.SingleOrDefault(x => x.Id == id);
            _cars.Remove(car);
        }

        public IEnumerable<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car item)
        {
            var car = _cars.SingleOrDefault(x => x.Id == item.Id);

            var index = _cars.IndexOf(car);
            _cars[index].Name = item.Name;
            car.Name = item.Name;
            car.MaxSpeed = item.MaxSpeed;
            car.Milage = item.Milage;
        }
    }
}
