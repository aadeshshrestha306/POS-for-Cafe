using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BisleriumCafe.Components.Services;

namespace BisleriumCafe.Components.Models
{
    public class Utils
    {
        public static string GetBasePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Components", "Data");
        } 
        public static string GetAppUsersFilePath()
        {
            return Path.Combine(GetBasePath(), "users.json");
        }
        public static string GetCoffeeFilePath()
        {
            return Path.Combine(GetBasePath(), "coffee.json");
        }
        public static string GetAddinsFilePath()
        {
            return Path.Combine(GetBasePath(), "addins.json");
        }
        public static string GetStaffPassword()
        {
            List<User> users = UsersService.GetAllUsers();
            User user = users.FirstOrDefault(x => x.role == "staff");
            return user.password;
        }
        public static string GetAdminPassword()
        {
            List<User> users = UsersService.GetAllUsers();
            User user = users.FirstOrDefault(x => x.role == "admin");
            return user.password;
        }
    }
}