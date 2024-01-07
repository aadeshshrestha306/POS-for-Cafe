using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisleriumCafe.Components.Models
{
    public static class AuthService
    {
        public static string Login(string password)
        {
            var errorMessage = "Invalid password";
            List<User> users = UsersService.GetAllUsers();
            User user = users.FirstOrDefault(x => x.password == password);
            if (user == null)
            {
                throw new Exception(errorMessage);
            }
            return user.password;
        }
    }
}