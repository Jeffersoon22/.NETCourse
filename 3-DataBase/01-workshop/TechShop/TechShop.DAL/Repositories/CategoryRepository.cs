using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.DAL.Models;

namespace TechShop.DAL.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly ShopDbContext _context;

        public CategoryRepository(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<Category> Create(Category model)
        {
            _context.Categories.Add(model);
            return model;
        }

        public async Task Delete(Category model)
        {
            _context.Remove(model);
        }

        public async Task<IEnumerable<Category>> Get()
        {
            return await _context.Categories.AsNoTracking().ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            return await _context.Categories
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Category> Update(Category model)
        {
            _context.Update(model);
            return model;
        }
    }
}
