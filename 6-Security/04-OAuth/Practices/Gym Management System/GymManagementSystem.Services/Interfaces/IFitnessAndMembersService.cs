using GymManagementSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Services.Interfaces
{
    public interface IFitnessAndMembersService
    {
        Task<FitnessAndMembers> Create(FitnessAndMembers member);
        Task<FitnessAndMembers> GetById(int id);
        Task Delete(FitnessAndMembers member);
    }
}
