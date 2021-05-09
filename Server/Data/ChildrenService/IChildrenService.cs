using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Server.Data.ChildrenService
{
    public interface IChildrenService
    {
        Task<Child> AddChildAsync(Child child, string address);
        Task RemoveChildAsync(int cprNumber, string address);
        Task<IList<Child>> GetChildrenAsync(string address);
    }
}