using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechShop.DAL.Models;
using TechShop.DAL.Repositories;

namespace TechShop.DAL
{
    public interface IUnitOfWork
    {
        IRepository<Category> Categories { get; }

        Task SaveChangesAsync();
    }
}
