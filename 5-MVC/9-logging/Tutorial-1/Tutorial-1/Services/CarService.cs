using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Models;
using Tutorial_1.Models.Repositories;

namespace Tutorial_1.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }

        public void AddCar(Car car)
        {
            _repository.AddCar(car);
        }

        public IEnumerable<Car> GetAllCars()
        {
            var cars = _repository.GetAllCars();
            return cars.OrderByDescending(x => x.MaxSpeed);
        }
    }
}
