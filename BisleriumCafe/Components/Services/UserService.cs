using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BisleriumCafe.Components.Models;

namespace BisleriumCafe.Components.Services
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
