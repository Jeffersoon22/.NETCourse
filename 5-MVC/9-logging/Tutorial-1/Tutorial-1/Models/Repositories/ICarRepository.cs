using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorial_1.Models.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        void AddCar(Car car);
    }
}
