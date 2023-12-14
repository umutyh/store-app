using Dapper;
using store.Database.Context;
using store.Database.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace store.Database.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;


        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UsersTable>> GetUserInformationAsync()
        {
            
            var query = "SELECT * FROM UsersTable";
            using (var connection = _context.CreateConnection())
            {
                var UsersTable = await connection.QueryAsync<UsersTable>(query);
                return UsersTable.ToList();
            }
        }

        public async Task<UsersTable> GetUserByUsername(string username)
        {
            var query = "SELECT UserName, Password FROM UsersTable WHERE UserName = @username";

            var parameters = new DynamicParameters();
            parameters.Add("username", username, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                var user = await connection.QuerySingleOrDefaultAsync<UsersTable>(query, parameters);
                return user;
            }
        }

    }
}
