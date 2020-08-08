using Projeto.Jwt.Models;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Jwt.Repositories
{
    public static class UserRepository
    {
        public static User Get(string userame, string password)
        {
            var users = new List<User>();
            users.Add(new User() { Id = 1, Username = "batman", Password = "batman", Role = "manager" });
            users.Add(new User() { Id = 2, Username = "robin", Password = "robin", Role = "employee" });
            return users.Where(x => x.Username.ToLower() == userame.ToLower() && x.Password.ToLower() == password.ToLower()).FirstOrDefault();
        }
    }
}
