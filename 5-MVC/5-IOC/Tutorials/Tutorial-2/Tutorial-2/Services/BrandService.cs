using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_2.Models;

namespace Tutorial_2.Services
{
    public class BrandService : IBrandService
    {
        public BrandService()
        {
            Guid = new Random().Next();
        }

        public int Guid { get; set; }

        public IEnumerable<Brand> GetBrands()
        {
            return new List<Brand> {
                new Brand("Marvel"),
                new Brand("DC"),
                new Brand("Disney"),
            };
        }
    }
}
