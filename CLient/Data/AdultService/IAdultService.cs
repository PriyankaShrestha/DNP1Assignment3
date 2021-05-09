using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Client.Data.AdultService
{
    public interface IAdultService
    {
        Task AddAdultAsync(Adult adult, string address);
        Task RemoveAdultAsync(Adult adult, string address);
        Task<Adult> GetAdultAsync(int adultId, string address);
        Task UpdateAdultAsync(Adult adult, string address);
        Task<IList<Adult>> GetAdultsAsync(string address);
        Task AddJobAsync(Job job, string address, int id);
    }
}