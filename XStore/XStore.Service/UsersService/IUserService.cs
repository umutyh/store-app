using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XStoreApp.ServiceClient.Models;

namespace XStore.Service.UsersService
{
    public interface IUserService
    {
        Task<IEnumerable<UsersServiceDB>> GetAllUsers();

        Task<bool> AuthenticateUserAsync(string username, string password);
    }
}
