using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Client.Data.FamilyService
{
    public interface IFamilyService
    {
        Task AddFamilyAsync(Family family);
        Task RemoveFamilyAsync(string address);
        Task UpdateFamilyAsync(string Address, Family family);
        Task<Family> GetFamilyAsync(string address);
        Task<IList<Family>> GetFamiliesAsync();
    }
}