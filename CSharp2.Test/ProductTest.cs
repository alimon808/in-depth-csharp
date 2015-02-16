using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharp2.Test
{
    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void SortByComparer()
        {
            List<Product> products = Product.GetSampleProducts();

            products.Sort(new ProductNameComparer());
            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
        }

        [Test]
        public void SortByAnonymousDelegateMethod()
        {
            List<Product> products = Product.GetSampleProducts();
            products.Sort(delegate(Product x, Product y) { return x.Name.CompareTo(y.Name); });
            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
        }

        [Test]
        public void QueryWithAnonymousMethodAndMethodGroupConversion()
        {
            List<Product> products = Product.GetSampleProducts();
            Predicate<Product> test = delegate(Product p) { return p.Price > 10m; };
            List<Product> matches = products.FindAll(test);
            Action<Product> print = Console.WriteLine;
            matches.ForEach(print);
        }

        [Test]
        public void QueryWithPriceIsNull()
        {
            List<Product> products = Product.GetSampleProducts();
            Predicate<Product> test = delegate(Product p) { return p.Price == null; };
            List<Product> matches = products.FindAll(test);
            Action<Product> print = Console.WriteLine;
            matches.ForEach(print);
        }
    }
}
