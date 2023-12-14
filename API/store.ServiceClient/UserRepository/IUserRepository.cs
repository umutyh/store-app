using store.Database.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace store.Database.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<UsersTable>> GetUserInformationAsync();
        Task<UsersTable> GetUserByUsername(string username);
    }
}
