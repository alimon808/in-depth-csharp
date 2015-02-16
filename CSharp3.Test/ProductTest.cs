using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharp3.Test
{
    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void SortWithLambdaExpression()
        {
            List<Product> products = Product.GetSampleProducts();

            // sort using lambda expressions
            products.Sort((x, y) => x.Name.CompareTo(y.Name));
            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
        }

        [Test]
        public void SortWithExtensionMethod()
        {
            List<Product> products = Product.GetSampleProducts();
            foreach (var p in products.OrderBy(p => p.Name))
            {
                Console.WriteLine(p);
            }
        }


        [Test]
        public void QueryWithLambdaExpression()
        {
            List<Product> products = Product.GetSampleProducts();
            foreach (var p in products.OrderBy(p => p.Price > 10))
            {
                Console.WriteLine(p);
            }
        }

        [Test]
        public void QueryWithPriceIsNull()
        {
            List<Product> products = Product.GetSampleProducts();
            foreach (var p in products.Where(p => p.Price == null))
            {
                Console.WriteLine(p);
            }
        }

        [Test]
        public void LinqQueryExpressionForProductPriceGreaterThan10()
        {
            List<Product> products = Product.GetSampleProducts();
            var filtered = from Product p in products
                           where p.Price > 10
                           select p;
            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
        }

        [Test]
        public void 
    }
}
