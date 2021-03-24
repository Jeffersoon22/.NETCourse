using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials.Models.Repository
{
    public class RealEstateRepository : IRealEstateRepository
    {
        private List<Property> _properties = new List<Property>
        {
            new Property { Name="Vake", Address = "Tbilisi", Square = 144},
            new Property { Name="Saburtalo", Address = "Tbilisi", Square = 144},
            new Property { Name="Gldani", Address = "Tbilisi", Square = 144}
        };

        public void AddProperty(Property property)
        {
            _properties.Add(property);
        }

        public IEnumerable<Property> GetAllProperties()
        {
            return _properties;
        }
    }
}
