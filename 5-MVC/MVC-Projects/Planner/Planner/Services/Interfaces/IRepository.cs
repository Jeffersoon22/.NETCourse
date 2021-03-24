using System.Collections.Generic;

namespace Planner.Services
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }
}
