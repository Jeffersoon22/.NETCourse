using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorial_2.Models;

namespace Tutorial_2.Services
{
    public interface IBrandService
    {
        public int Guid { get; set; }
        IEnumerable<Brand> GetBrands();
    }
}
