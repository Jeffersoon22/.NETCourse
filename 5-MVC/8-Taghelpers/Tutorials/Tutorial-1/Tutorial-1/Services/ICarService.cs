using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_1.Models;

namespace Tutorial_1.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetAllCars();
        void AddCar(Car car);
    }
}
