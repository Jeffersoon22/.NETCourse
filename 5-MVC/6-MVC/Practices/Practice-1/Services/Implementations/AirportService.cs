using Practice_1.Model;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practice_1.Services
{
    public class AirportService : IAirportService
    {
        List<Airport> airports;

        public void AddAirport(Airport airport)
        {
            try
            {
                airports = Deserialize<List<Airport>>();
            }
            catch
            {
                airports = new List<Airport>();
            };

            airports.Add(airport);

            Serialize<List<Airport>>(airports);
        }


        public IEnumerable<Airport> GetAirports()
        {
            
            try
            {
                 airports = Deserialize<List<Airport>>();
            }
            catch 
            {
                 airports = new List<Airport>();
            };

            return airports;
        }


        private readonly string FileName = "Airports.dat";
        private readonly IFormatter formatter = new BinaryFormatter();
        

        public void Serialize<T>(T instance)
        {
            using (FileStream s = File.Create(FileName))
            {
                formatter.Serialize(s, instance);
            }
        }
        public T Deserialize <T>()
        {
            using FileStream s = File.OpenRead(FileName);
            T data = (T)formatter.Deserialize(s);
            return data;
        }

    }
}

