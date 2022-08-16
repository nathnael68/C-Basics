using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Product
    {
        private static List<Product> products = new List<Product>();
        public string itemName { get; set; }
        public int number { get; set; }
        public string date { get; set; }
        public int inventoryNumber { get; set; }
        public int count { get; set; }
        public double price { get; set; }
        public void save()
        {
            products.Add(this);
        }
        public static List<Product> getAll()
        {
            return products;
        }
        public bool isAvail { get; set; }
        public static Product findOne (string name)
        {
            return products.Find(p => p.itemName == name);
        }
        public static Product findInvent(int id)
        {
            return products.Find(p => p.inventoryNumber == id);
        }
    }
}
