using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Model
{
    [Serializable]
    public class Airport
    {
        public List<Airline> Airlines = new List<Airline>();
        public string Name { get; set; }
        public string City { get; set; }
        public bool IsInternational { get; set; }

        public Airport(string name, string city, bool isInternational)
        {
            Name = name;
            City = city;
            IsInternational = isInternational;
        }

    }
}
