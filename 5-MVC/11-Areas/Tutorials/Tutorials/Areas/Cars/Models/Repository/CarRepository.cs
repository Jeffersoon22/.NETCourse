using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials.Models.Repository
{
    public class CarRepository : ICarRepository
    {
        private List<Car> _cars = new List<Car>
        {
            new Car { Name="Tesla", MaxSpeed=249 },
            new Car { Name="Mercedes", MaxSpeed=260 },
            new Car { Name="Nissan 350Z", MaxSpeed=387 },
            new Car { Name="Toyota Prius", MaxSpeed=300 },
        };

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _cars;
        }
    }
}
