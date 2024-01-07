using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BisleriumCafe.Components.Models
{
    public static class UsersService
    {
        public static List<User> GetAllUsers()
        {
            string appUsersFilePath = Utils.GetAppUsersFilePath();
            var json = File.ReadAllText(appUsersFilePath);
            return JsonSerializer.Deserialize<List<User>>(json);
        }
    }
}
