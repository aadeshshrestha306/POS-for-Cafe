using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace BisleriumCafe.Components.Models
{
    public class Order
    {
        public string Number { get; set; }
        public List<CoffeeItem> Coffees { get; set; }
        public List<AddinItem> Addins { get; set; }
        public DateTime Date { get; set; }
    }

    public class CoffeeItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    public class AddinItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

}