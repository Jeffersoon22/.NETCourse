using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechShop.DAL;
using TechShop.DAL.Models;
using TechShop.DAL.Repositories;
using TechShop.Services.Interfaces;

namespace TechShop.Services.Implementation
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork uow)
        {
            _unitOfWork = uow;
        }

        public async Task<Category> Create(Category category)
        {
            var result = await _unitOfWork.Categories.Create(category);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task Delete(Category category)
        {
            await _unitOfWork.Categories.Delete(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<Category> Update(Category category)
        {
            var result = await _unitOfWork.Categories.Update(category);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<Category>> Get()
        {
            return await _unitOfWork.Categories.Get();
        }

        public async Task<Category> GetById(int id)
        {
            return await _unitOfWork.Categories.GetById(id);
        }

    }
}
