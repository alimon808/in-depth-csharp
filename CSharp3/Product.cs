using System;
using System.Collections.Generic;

namespace CSharp3
{
    public class Product
    {
        // C# 3 - auto implemented properties
        public string Name { get; private set; }
        public decimal? Price { get; private set; }
        public int SupplierId { get; private set; }

        public Product(string name, decimal? price, int supplierId = 1)
        {
            Name = name;
            Price = price;
            SupplierId = supplierId;
        }
        public Product()
        {

        }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product {Name = "West Side Story", Price = 9.99m, SupplierId = 1},
                new Product {Name ="Assassins", Price = 14.99m, SupplierId = 2},
                new Product {Name ="Frogs", Price = 13.99m, SupplierId = 2},
                new Product {Name ="Sweeney Todd", Price = 10.99m, SupplierId = 3},
                new Product {Name ="Unknown", Price = null, SupplierId = 4},
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
