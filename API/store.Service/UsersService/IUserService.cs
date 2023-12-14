using store.Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace store.Service.UsersService
{
    public interface IUserService
    {
        Task<List<UsersServiceDB>> GetAllUsers();
    }
}
