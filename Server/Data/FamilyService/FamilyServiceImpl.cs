using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Server.DataContext;

namespace Server.Data.FamilyService
{
    public class FamilyServiceImpl : IFamilyService
    {
        public async Task<Family> AddFamilyAsync(Family family)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                await dbContext.FamiliesDB.AddAsync(family);
                await dbContext.SaveChangesAsync();
                return family;
            }
        }

        public async Task RemoveFamilyAsync(string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                Family fam = await GetFamilyAsync(address);
                dbContext.FamiliesDB.Remove(fam);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<Family> UpdateFamilyAsync(string address, Family family)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                Family fam = await GetFamilyAsync(address);
                Console.WriteLine(fam.ToString());
                fam.City = family.City;
                fam.Floor = family.Floor;
                fam.HouseNumber = family.HouseNumber;
                fam.StreetName = family.StreetName;
                dbContext.Update(fam);
                await dbContext.SaveChangesAsync();
                Console.WriteLine(fam.ToString());
                return fam;
            }
        }

        public async Task<Family> GetFamilyAsync(string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                IList<Family> families = await GetFamiliesAsync();
                Family fam = families.FirstOrDefault(f => f.Address().Equals(address));
                return fam;
            }
        }

        public async Task<IList<Family>> GetFamiliesAsync()
        {
            using (DataAccess dbContext = new DataAccess())
            {
                 IList<Family> families = dbContext.FamiliesDB.ToList();
                 return families;
            }
        }
    }
}