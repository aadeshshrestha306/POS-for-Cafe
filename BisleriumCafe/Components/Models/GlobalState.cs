using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisleriumCafe.Components.Models
{
    public class GlobalState
    {
        public string staffPassword { get; set; } = Utils.GetStaffPassword();

        public string adminPassword { get; set; } = Utils.GetAdminPassword();
    }
}