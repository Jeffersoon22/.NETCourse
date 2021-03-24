using Practice_1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Practice_1.Services
{
    public class AirlineService :IAirlineService
    {
        List<Airline> airlines;

        public void AddAirline(Airline airline)
        {
            try
            {
                airlines = Deserialize<List<Airline>>();
            }
            catch
            {
                airlines = new List<Airline>();
            };

            airlines.Add(airline);

            Serialize<List<Airline>>(airlines);
        }


        public IEnumerable<Airline> GetAllAirlines()
        {

            try
            {
                airlines = Deserialize<List<Airline>>();
            }
            catch
            {
                airlines = new List<Airline>();
            };

            return airlines;
        }


        private readonly string FileName = "Airlines.dat";
        private readonly IFormatter formatter = new BinaryFormatter();

        public AirlineService()
        {
        }

        public void Serialize<T>(T instance)
        {
            using (FileStream s = File.Create(FileName))
            {
                formatter.Serialize(s, instance);
            }
        }
        public T Deserialize<T>()
        {
            using FileStream s = File.OpenRead(FileName);
            T data = (T)formatter.Deserialize(s);
            return data;
        }

    }
}
