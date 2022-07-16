using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class Product
    {
        static List<Product> products = new List<Product>();
        public int number { get; set; }
        public string date { get; set; }
        public int invnumb { get; set; }
        public string objname { get; set; }
        public int count { get; set; }
        public double price { get; set; }
     
        private static List<Product> product = new List<Product>();
        public void save() { products.Add(this); }

        public static List<Product> GetAll()
        {
            return products;
        }
       
            
    }
}
