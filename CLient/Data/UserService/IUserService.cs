using System.Threading.Tasks;
using Models;

namespace Client.Data.UserService
{
    public interface IUserService
    {
        Task AddUserAsync(User user);
        Task<User> ValidateUserAsync(string username, string password);
    }
}