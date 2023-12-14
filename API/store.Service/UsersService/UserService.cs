using AutoMapper;
using store.Database.UserRepository;
using store.Service.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace store.Service.UsersService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repoUser;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repoUser, IMapper mapper)
        {
            _repoUser = repoUser;
            _mapper = mapper;
        }
        public async Task<List<UsersServiceDB>> GetAllUsers()
        {
            var users = await _repoUser.GetUserInformationAsync();
            return _mapper.Map<List<UsersServiceDB>>(users);
        }
    }
}
