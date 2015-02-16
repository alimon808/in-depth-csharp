using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4
{
    public class Product
    {
        readonly string name;
        public string Name { get { return name; } }
        readonly decimal? price;
        public decimal? Price { get { return price; } }

        // default values
        public Product(string name, decimal? price = null)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            // c# 2 - strongly type collections
            //ArrayList list = new ArrayList();
            //List<Product> list = new List<Product>();
            //list.Add(new Product("West Side Story", 9.99m));
            //list.Add(new Product("Assassins", 14.99m));
            //list.Add(new Product("Frogs", 13.99m));
            //list.Add(new Product("Sweeney Todd", 10.99m));

            // c# 3 - anonymous types
            //return new List<Product>
            //{
            //    new Product {Name = "West Side Story", Price = 9.99m},
            //    new Product {Name ="Assassins", Price = 14.99m},
            //    new Product {Name ="Frogs", Price = 13.99m},
            //    new Product {Name ="Sweeney Todd", Price = 10.99m}
            //};

            // c# 4 - Named arguments
            return new List<Product>
            {
                new Product ( name: "West Side Story", price: 9.99m),
                new Product ( name: "Assassins", price: 14.99m ),
                new Product ( name: "Frogs", price: 13.99m ),
                new Product ( name: "Sweeney Todd", price: 10.99m ),
                new Product ( name: "Unreleased product" ) // price is by default null

            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
