using System.Collections.Generic;
namespace CSharp2
{
    public class Product
    {
        string name;
        public string Name { 
            get { return name; }
            // new to c# 2
            private set { name = value; }
        }

        // allow nullable price
        decimal? price;
        public decimal? Price { 
            get { return price; }
            // new to c# 2
            private set { price = value; }
        }

        public Product(string name, decimal? price)
        {
            // c# 2 -private setters
            Name = name;
            Price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            // c# 2 - strongly type collections
            //ArrayList list = new ArrayList();
            List<Product> list = new List<Product>();
            list.Add(new Product("West Side Story", 9.99m));
            list.Add(new Product("Assassins", 14.99m));
            list.Add(new Product("Frogs", 13.99m));
            list.Add(new Product("Sweeney Todd", 10.99m));
            list.Add(new Product("Unknown", null));

            return list;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}
