using Planner.Models;

namespace Planner.Services
{
    public interface IAuthService
    {
        bool IsUserValid(User user, out string token);
        bool IsTokenValid(string token);
    }
}
