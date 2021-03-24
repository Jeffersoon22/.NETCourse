using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.DAL.Repositories
{
    public interface IRepository<T>
    {
        Task<T> Create(T model);
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);
        Task<T> Update(T model);
        Task Delete(T model);
    }
}
