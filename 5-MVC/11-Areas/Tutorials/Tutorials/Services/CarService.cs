using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorials.Models;
using Tutorials.Models.Repository;

namespace Tutorials.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        public IEnumerable<Car> GetTop3Cars()
        {
            var cars = _carRepository.GetAllCars();

            var top3Cars = cars.OrderByDescending(x => x.MaxSpeed).Take(3);

            return top3Cars;
        }
    }
}
