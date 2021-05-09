using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Client.Data.UserService
{
    public class UserService : IUserService
    {
        private HttpClient client;
        private string uri = "https://localhost:5003";

        public UserService()
        {
            client = new HttpClient();
        }
        
        public async Task AddUserAsync(User user)
        {
           string serializedUser = JsonSerializer.Serialize(user, new JsonSerializerOptions
           {
               PropertyNameCaseInsensitive = true
           });

            StringContent content = new StringContent(
                serializedUser,
                Encoding.UTF8,
                "application/json"
            );

            Console.WriteLine(user.Username);
            await client.PostAsync(uri + "/users", content);
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            HttpResponseMessage userAsync =
                await client.GetAsync(uri + $"/users?username={username}&password={password}");
            if (userAsync.IsSuccessStatusCode)
            {
                string userAsJson = await userAsync.Content.ReadAsStringAsync();
                User first = JsonSerializer.Deserialize<User>(userAsJson, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return first;
            }
            throw new Exception("User Not Found");
        }
    }
}