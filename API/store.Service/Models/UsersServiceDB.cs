using System.ComponentModel.DataAnnotations.Schema;

namespace store.Service.Models
{
    [Table("UsersTable")]
    public class UsersServiceDB
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
