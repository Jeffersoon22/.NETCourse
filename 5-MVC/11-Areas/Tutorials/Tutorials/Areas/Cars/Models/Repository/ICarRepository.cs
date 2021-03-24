using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials.Models.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        void AddCar(Car car);
    }
}
