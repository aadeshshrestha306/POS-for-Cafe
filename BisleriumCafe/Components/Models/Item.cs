using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BisleriumCafe.Components.Models
{
    public class OrderService
    {
        public string Number { get; set; }
        public List<CoffeeItem> Coffees { get; set; }
        public List<AddinItem> Addins { get; set; }
        public String Date { get; set; }
    }

    public class OrderTransaction
    {
        public string Number { get; set; }
        public List<CoffeeItem> Coffees { get; set; }
        public List<AddinItem> Addins { get; set; }
        public DateTime Date { get; set; }
    }

    public class CoffeeItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class AddinItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class ItemCount
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }


}