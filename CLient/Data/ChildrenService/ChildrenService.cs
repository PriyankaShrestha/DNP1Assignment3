using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Client.Data.ChildrenService
{
    public class ChildrenService :IChildrenService
    {
        private HttpClient client;
        private string uri = "https://localhost:5003";

        public ChildrenService()
        {
            client = new HttpClient();
        }
        
        public async Task AddChildAsync(Child child, string address)
        {
           string serializedChild = JsonSerializer.Serialize(child);

            StringContent content = new StringContent(
                serializedChild,
                Encoding.UTF8,
                "application/json"
            );

            await client.PostAsync($"{uri}/children", content);
        }

        public async Task RemoveChildAsync(Child child, string address)
        {
            await client.DeleteAsync($"{uri}/children/{address}/{child.CPRNumber}");
        }
        
        public async Task<IList<Child>> GetChildrenAsync(string address)
        { 
            Task<string> stringAsync = client.GetStringAsync(uri + $"/children/{address}");
            string message = await stringAsync;
            List<Child> result = JsonSerializer.Deserialize<List<Child>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
    }
}