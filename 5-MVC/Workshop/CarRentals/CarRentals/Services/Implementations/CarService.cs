using CarRentals.Models;
using CarRentals.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.Services
{
    public class CarService : ICarService
    {
        private readonly IRepository<Car> _carRepository;

        public CarService(IRepository<Car> carRepository )
        {
            _carRepository = carRepository;
        }
        public void AddCar(Car car)
        {
            _carRepository.Add(car);
        }

        public void DeleteCar(int id)
        {
            _carRepository.Delete(id);
        }

        public IEnumerable<Car> GetCars()
        {
            return _carRepository.GetAll();
        }

        public void UpdateCar(Car car)
        {
            _carRepository.Update(car);
        }
    }

}
