using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentals.Services
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }
}
