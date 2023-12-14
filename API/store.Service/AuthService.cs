using AutoMapper;
using store.Database;
using store.Database.UserRepository;
using System.Threading.Tasks;

namespace store.Service
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly AesEncryptionService _aesEncryptionService;

        public AuthService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _aesEncryptionService = new AesEncryptionService(GlobalConstants.encryptionKey);
        }
        public async Task<bool> AuthenticateUser(string username, string password)
        {

            var user = await _userRepository.GetUserByUsername(username);

            if (user != null)
            {
                string storedPassword = _aesEncryptionService.Encrypt(user.Password);

                if (storedPassword == password)
                {
                    return true;
                }
                _aesEncryptionService.Encrypt(user.Password);
            }

            return false;
        }
    }
}
