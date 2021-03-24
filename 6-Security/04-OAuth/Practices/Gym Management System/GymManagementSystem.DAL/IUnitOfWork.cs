using GymManagementSystem.DAL.Models;
using GymManagementSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.DAL
{
    public interface IUnitOfWork
    {
        IRepository<FitnessAndMembers> FitnessAndMembers { get; }

        Task SaveChangesAsync();
    }
}
