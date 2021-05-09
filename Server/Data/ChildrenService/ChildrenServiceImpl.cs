using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using Server.DataContext;

namespace Server.Data.ChildrenService
{
    public class ChildrenServiceImpl :IChildrenService
    {
        public async Task<Child> AddChildAsync(Child child, string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                IList<Family> result = await dbContext.FamiliesDB.ToListAsync();
                Family fam = result.FirstOrDefault(f => f.Address().Equals(address));
                fam.Children.Add(child);
                dbContext.Update(fam);
                await dbContext.SaveChangesAsync();
                return child;
            }
        }

        public async Task RemoveChildAsync(int cprNumber, string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                IList<Family> result = await dbContext.FamiliesDB.ToListAsync();
                Family fam = result.FirstOrDefault(f => f.Address().Equals(address));
                Child child = fam.Children.FirstOrDefault(a => a.CPRNumber == cprNumber);
                fam.Children.Remove(child);
                dbContext.Update(fam);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IList<Child>> GetChildrenAsync(string address)
        {
            using (DataAccess dbContext = new DataAccess())
            {
                IList<Family> result = await dbContext.FamiliesDB.ToListAsync();
                Family fam = result.FirstOrDefault(f => f.Address().Equals(address));
                return fam.Children.ToList();
            }
        }
    }
}