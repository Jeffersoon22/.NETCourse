using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorials.Models;

namespace Tutorials.Services
{
    public interface IRealEstateService
    {
        IEnumerable<Property> GetTop3Properties();
        void AddProperty(Property property);
    }
}
