

using GymManagementSystem.DAL;
using GymManagementSystem.DAL.Models;
using GymManagementSystem.Services.Interfaces;
using System.Threading.Tasks;

namespace GymManagementSystem.Services.Implementation
{
    public class FitnessAndMembersService : IFitnessAndMembersService
    {

        private readonly IUnitOfWork _unitOfWork;

        public FitnessAndMembersService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<FitnessAndMembers> Create(FitnessAndMembers member)
        {
            var created = await _unitOfWork.FitnessAndMembers.Create(member);
            await _unitOfWork.SaveChangesAsync();
            return created;
        }

        public async Task Delete(FitnessAndMembers member)
        {
            await _unitOfWork.FitnessAndMembers.Delete(member);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<FitnessAndMembers> GetById(int id)
        {
            var result = await _unitOfWork.FitnessAndMembers.GetById(id);
            await _unitOfWork.SaveChangesAsync();
            return result;
        }
    }
}

