using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorials.Models.Repository
{
    public interface IRealEstateRepository
    {
        IEnumerable<Property> GetAllProperties();
        void AddProperty(Property property);
    }
}
