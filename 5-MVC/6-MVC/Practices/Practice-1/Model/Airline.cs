using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Model
{
    [Serializable]
    public class Airline
    {
        public string AirlineName;
        public int AircraftCount;
        public bool IsLowcost;
        public int MaximumLuggageWeight;

        public Airline(string airlineName, int aircraftCount, bool isLowcost, int maximumLuggageWeight)
        {
            AirlineName = airlineName;
            AircraftCount = aircraftCount;
            IsLowcost = isLowcost;
            MaximumLuggageWeight = maximumLuggageWeight;
        }
    }
}
