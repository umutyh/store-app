using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XStore.ServiceClient;
using XStoreApp.ServiceClient;
using XStoreApp.ServiceClient.Models;

namespace XStore.Service.UsersService
{
    public class UserService : IUserService
    {
        private readonly StoreAPI apiClient = new StoreAPI() { BaseUri = new Uri("http://10.0.2.2:5122/") };
        private readonly AesEncryptionService _aesEncryptionService;
        public UserService()
        {
            _aesEncryptionService = new AesEncryptionService(GlobalConstants.encryptionKey);
        }

        public async Task<IEnumerable<UsersServiceDB>> GetAllUsers()
        {
            var users = await apiClient.UsersWithHttpMessagesAsync();
            if (users.Response.IsSuccessStatusCode)
            {
                if (users.Body == null)
                {
                    throw new Exception("Error");
                }
                try
                {
                    return users.Body.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception($"{ex.Message}");
                }

            }
            return null;
        }

        public async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            var request = new UsersServiceDB
            {
                UserName = username,
                Password = password
            };

            var data = await apiClient.LoginWithHttpMessagesAsync(request);
            if (data.Response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
