using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorials.Models;
using Tutorials.Models.Repository;

namespace Tutorials.Services
{
    public class RealEstateService : IRealEstateService
    {
        private readonly IRealEstateRepository _realEstateRepository;

        public RealEstateService(IRealEstateRepository realEstateRepository)
        {
            _realEstateRepository = realEstateRepository;
        }

        public void AddProperty(Property property)
        {
            _realEstateRepository.AddProperty(property);
        }

        public IEnumerable<Property> GetTop3Properties()
        {
            return _realEstateRepository.GetAllProperties();
        }
    }
}
