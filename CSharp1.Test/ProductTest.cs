using System;
using System.Collections;
using NUnit.Framework;

namespace CSharp1.Test
{
    [TestFixture]
    public class ProductTest
    {
        [Test]
        public void SortByProductName()
        {
            ArrayList products = Product.GetSampleProducts();
            products.Sort(new ProductNameComparer());
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        [Test]
        public void QueryByPriceGreaterThan10()
        {
            ArrayList products = Product.GetSampleProducts();
            foreach (Product product in products)
            {
                if (product.Price > 10)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}
