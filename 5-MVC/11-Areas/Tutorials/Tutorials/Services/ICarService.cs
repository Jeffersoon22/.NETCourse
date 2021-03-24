using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorials.Models;

namespace Tutorials.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetTop3Cars();
        void AddCar(Car car);
    }
}
