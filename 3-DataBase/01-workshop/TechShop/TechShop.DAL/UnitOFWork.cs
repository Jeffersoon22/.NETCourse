using System.Threading.Tasks;
using TechShop.DAL.Models;
using TechShop.DAL.Repositories;

namespace TechShop.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopDbContext _context;

        private IRepository<Category> _categories;

        public UnitOfWork(ShopDbContext context)
        {
            _context = context;
        }

        public IRepository<Category> Categories => _categories ?? (new CategoryRepository(_context));

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
