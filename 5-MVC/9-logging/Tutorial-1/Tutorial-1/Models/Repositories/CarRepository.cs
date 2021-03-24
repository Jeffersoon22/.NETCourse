using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Models.Repositories
{
    public class CarRepository : ICarRepository
    {

        private List<Car> _cars = new List<Car>() {
            new Car{Name = "Porsche", MaxSpeed= 387 },
            new Car{Name = "Toyota Prius", MaxSpeed= 180}
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
