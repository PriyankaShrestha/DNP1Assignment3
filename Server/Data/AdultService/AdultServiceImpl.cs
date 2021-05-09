using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using Server.DataContext;

namespace Server.Data.AdultService
{
    public class AdultServiceImpl : IAdultService
    {
        public async Task<Adult> AddAdultAsync(Adult adult, string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                IList<Family> result = await dbContext.FamiliesDB.ToListAsync();
                Family fam = result.FirstOrDefault(f => f.Address().Equals(address));
                fam.Adults.Add(adult);
                dbContext.Update(fam);
                await dbContext.SaveChangesAsync();
                return adult;
            }
        }

        public async Task RemoveAdultAsync(int cprNumber, string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                IList<Family> result = await dbContext.FamiliesDB.ToListAsync();
                Family fam = result.FirstOrDefault(f => f.Address().Equals(address));
                Adult adu = fam.Adults.FirstOrDefault(a => a.CPRNumber == cprNumber);
                fam.Adults.Remove(adu);
                dbContext.Update(fam);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<Adult> GetAdultAsync(int adultId, string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                IList<Family> result = await dbContext.FamiliesDB.ToListAsync();
                Family fam = result.FirstOrDefault(f => f.Address().Equals(address));
                Adult adu = fam.Adults.FirstOrDefault(a => a.CPRNumber == adultId);
                return adu;
            }
        }

        public async Task<Adult> UpdateAdultAsync(Adult adult, string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                IList<Family> result = await dbContext.FamiliesDB.ToListAsync();
                Family fam = result.FirstOrDefault(f => f.Address().Equals(address));
                Adult adu = fam.Adults.FirstOrDefault(a => a.CPRNumber == adult.CPRNumber);
                adu.Age = adult.Age;
                adu.Height = adult.Height;
                adu.Weight = adult.Weight;
                await dbContext.SaveChangesAsync();
                return adu;
            }
        }

        public async Task<IList<Adult>> GetAdultsAsync(string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                IList<Family> result = await dbContext.FamiliesDB.ToListAsync();
                Family fam = result.FirstOrDefault(f => f.Address().Equals(address));
                return fam.Adults.ToList();
            }
        }

        public async Task<Job> AddJobAsync(Job job, string address, int id)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                Adult adult = await GetAdultAsync(id, address);
                adult.Job.Equals(job);
                return job;
            }
        }
    }
}