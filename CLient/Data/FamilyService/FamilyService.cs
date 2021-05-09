using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Client.Data.FamilyService
{
    public class FamilyService : IFamilyService
    {
        private HttpClient client;
        private string uri = "https://localhost:5003";

        public FamilyService()
        {
            client = new HttpClient();
        }

        public async Task AddFamilyAsync(Family family)
        {
            string serializedFamily = JsonSerializer.Serialize(family);

            StringContent content = new StringContent(
                serializedFamily,
                Encoding.UTF8,
                "application/json"
            );

            await client.PostAsync($"{uri}/families" , content);
        }

        public async Task RemoveFamilyAsync(string address)
        {
            await client.DeleteAsync($"{uri}/families/{address}");
        }

        public async Task UpdateFamilyAsync(string address, Family family)
        {
           string serializedFamily = JsonSerializer.Serialize(family, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            StringContent content = new StringContent(
                serializedFamily,
                Encoding.UTF8,
                "application/json"
            );

            await client.PatchAsync($"{uri}/families/{address}", content);
        }

        public async Task<Family> GetFamilyAsync(string address)
        {
           Task<string> familyAsync = client.GetStringAsync(uri + $"/families/{address}");
            string message = await familyAsync;
            Family family =  JsonSerializer.Deserialize<Family>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return family;
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
           Task<string> stringAsync = client.GetStringAsync(uri + $"/families");
           string message = await stringAsync;
           List<Family> result = JsonSerializer.Deserialize<List<Family>>(message, new JsonSerializerOptions
           {
               PropertyNameCaseInsensitive = true
           });
           return result;
        }
    }
}