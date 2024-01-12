using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisleriumCafe.Components.Models
{
    public class OrderReport
    {
        public string Number { get; set; }
        public int Purchases { get; set; }
        public int DailyStreak { get; set; }
        public int FreeCoffeeCount { get; set; }
        public int DiscountPercentage { get; set; }
        public string LastPurchaseDate { get; set; } 

    }
}
