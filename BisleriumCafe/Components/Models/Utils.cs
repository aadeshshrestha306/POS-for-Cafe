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
            string path =  Path.Combine("E:\\Year 3 CW\\Application Development\\bislerium_cafe-Invalid_Input\\BisleriumCafe", "Data");
            return Path.GetFullPath(path);
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
            return Path.Combine(GetBasePath(), "addin.json");
        }
        public static string GetMemberFilePath()
        {
            return Path.Combine(GetBasePath(), "member.json");
        }
        
        public static string GetOrderFilePath()
        {
            return Path.Combine(GetBasePath(), "order.json");
        }
        public static string GetOrderReportFilePath()
        {
            return Path.Combine(GetBasePath(), "orderReport.json");
        }
        public static string GetItemsFilePath()
        {
            return Path.Combine(GetBasePath(), "items.json");
        }
        public static string GetCoffeeCountFilePath()
        {
            return Path.Combine(GetBasePath(), "coffeCount.json");
        }
        public static string GetAddinCountFilePath()
        {
            return Path.Combine(GetBasePath(), "addinCount.json");
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