using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechShop.DAL.Models;

namespace TechShop.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<Category> Create(Category category);
        Task<IEnumerable<Category>> Get();
        Task<Category> GetById(int id);
        Task<Category> Update(Category category);
        Task Delete(Category category);

    }
}
