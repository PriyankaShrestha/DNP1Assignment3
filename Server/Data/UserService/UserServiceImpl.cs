using System;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Server.DataContext;

namespace Server.Data.UserService
{
    public class UserServiceImpl : IUserService
    {
        public async Task<User> AddUserAsync(User user)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                await dbContext.UsersDB.AddAsync(user);
                await dbContext.SaveChangesAsync();
                return user;
            }
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                User user = dbContext.UsersDB.FirstOrDefault(c =>
                    c.Username.Equals(username) && c.Password.Equals(password));
                return user;
            }
        }
    }
}