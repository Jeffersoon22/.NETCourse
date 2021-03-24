using GymManagementSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL.Repositories
{
    class FitnessAndMembersRepository : IRepository<FitnessAndMembers>
    {

        private readonly GymDbContext _context;

        public FitnessAndMembersRepository(GymDbContext context)
        {
            _context = context;
        }


        public async Task<FitnessAndMembers> Create(FitnessAndMembers model)
        {
            _context.FitnessAndMembers.Add(model);
            return model;
        }

        public async Task Delete(FitnessAndMembers model)
        {
            _context.Remove(model);
        }

        public async Task<IEnumerable<FitnessAndMembers>> Get()
        {
            throw new NotImplementedException();

        }

        public async Task<FitnessAndMembers> GetById(int id)
        {
            return await _context.FitnessAndMembers
                 .AsNoTracking()
                 .SingleOrDefaultAsync(x => x.MemberId == id);
        }

        public async Task<FitnessAndMembers> Update(FitnessAndMembers model)
        {
            throw new NotImplementedException();
        }
    }
}
