using System;
using System.Collections.Generic;
using CSharp.Collections;
using NUnit.Framework;

namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class BasicSortedSetTests
    {
        [Test]
        public void ShouldTestBasicSortedSet()
        {
            var sut = new BasicSortedSet();
            var cities = sut.BigCities();

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
