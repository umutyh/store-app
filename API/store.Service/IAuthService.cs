using System.Threading.Tasks;

namespace store.Service
{
    public interface IAuthService
    {
        Task<bool> AuthenticateUser(string username, string password);
    }
}
