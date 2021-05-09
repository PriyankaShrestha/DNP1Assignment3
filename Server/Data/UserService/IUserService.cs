using System.Threading.Tasks;
using Models;

namespace Server.Data.UserService
{
    public interface IUserService
    {
        Task<User> AddUserAsync(User user);
        Task<User> ValidateUserAsync(string username, string password);
    }
}