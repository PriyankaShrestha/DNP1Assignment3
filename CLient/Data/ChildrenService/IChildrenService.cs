using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Client.Data.ChildrenService
{
    public interface IChildrenService
    {
        Task AddChildAsync(Child child, string address);
        Task RemoveChildAsync(Child child, string address);
        Task<IList<Child>> GetChildrenAsync(string address);
    }
}