using Practice_1.Model;
using System.Collections.Generic;

namespace Practice_1.Services
{
    public interface IAirlineService
    {
        IEnumerable<Airline> GetAllAirlines();
        void AddAirline(Airline airline);
        public void Serialize<T>(T instance);
        public T Deserialize<T>();

    }
}