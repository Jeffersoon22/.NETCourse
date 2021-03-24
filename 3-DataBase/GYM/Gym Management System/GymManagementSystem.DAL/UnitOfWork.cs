using GymManagementSystem.DAL.Models;
using GymManagementSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GymDbContext _context;

        private IRepository<FitnessAndMembers> _fitnessAndMembers;

        public UnitOfWork(GymDbContext context)
        {
            _context = context;
        }

        public IRepository<FitnessAndMembers> FitnessAndMembers => _fitnessAndMembers ?? (new FitnessAndMembersRepository(_context));

        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
    }
}
