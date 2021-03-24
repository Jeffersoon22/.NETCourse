using Practice_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Services
{
    public interface IAirportService
    {
        IEnumerable<Airport> GetAirports();
        void AddAirport(Airport airport);
        public void Serialize<T>(T instance);
        public T Deserialize<T>();
    }
}
