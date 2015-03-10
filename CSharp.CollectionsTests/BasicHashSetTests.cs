using System;
using System.Collections.Generic;
using CSharp.Collections;
using System.Linq;
using NUnit.Framework;

namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class BasicHashSetTests
    {
        [Test]
        public void ShouldTestBasicHashSet()
        {
            var sut = new BasicHashSet();
            var list = sut.ListBigCities();
            var hash = sut.HashBigCities();

            Assert.That(6, Is.EqualTo(list.Count));
            Assert.That(5, Is.EqualTo(hash.Count));

            foreach (var city in hash)
            {
                Console.WriteLine(city);
            }
        }

        [Test]
        public void ShouldIgnoreCaseInHashSet()
        {
            var sut = new BasicHashSet();
            var hash = sut.HashBigCitiesIgnoreCase();

            Assert.That(5, Is.EqualTo(hash.Count));

            foreach (var city in hash)
            {
                Console.WriteLine(city);
            }

        }

        [Test]
        public void ShouldIgnoreCaseInHashSetUsingCustomComparer()
        {
            var sut = new BasicHashSet();
            var hash = sut.HashBigCitiesIgnoreCaseUsingCustomEqualityComparer();

            Assert.That(5, Is.EqualTo(hash.Count));

            foreach (var city in hash)
            {
                Console.WriteLine(city);
            }

        }

        [Test]
        public void ShouldReturnBigCitiesInUK()
        {
            var sut = new BasicHashSet();
            var hash = sut.HashBigCitiesInUK();

            Assert.That(2, Is.EqualTo(hash.Count));

            foreach (var city in hash)
            {
                Console.WriteLine(city);
            }

        }

        [Test]
        public void ShouldReturnBigCitiesInUKUsingLINQ()
        {
            var sut = new BasicHashSet();
            var cities = sut.EnumerableBigCitiesInUK().ToList();

            Assert.That(2, Is.EqualTo(cities.Count));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }

        [Test]
        public void ShouldReturnCitiesInBigCitiesAndUK()
        {
            var sut = new BasicHashSet();
            var cities = sut.BigCitiesInUKAndTheWorld();

            Assert.That(6, Is.EqualTo(cities.Count));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }

        [Test]
        public void ShouldReturnBigCitiesSymmetricDifference()
        {
            var sut = new BasicHashSet();
            var cities = sut.BigCitiesSymmetricDifference();

            Assert.That(4, Is.EqualTo(cities.Count));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }

        [Test]
        public void ShouldReturnParisNewYork()
        {
            var sut = new BasicHashSet();
            var cities = sut.BigCitiesDifference();

            Assert.That(2, Is.EqualTo(cities.Count));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }

        [Test]
        public void ShouldTestSetComparisonOperations()
        {
            var bigCitiesArr = new HashSet<string>()
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            var bigUKCities = new HashSet<string>()
            {
                "Sheffield", "Manchester"
            };

            Assert.That(bigCitiesArr.IsSupersetOf(bigUKCities), Is.True);
            Assert.That(bigUKCities.IsSubsetOf(bigCitiesArr), Is.True);

            Assert.That(bigCitiesArr.SetEquals(bigUKCities), Is.False);

        }
    }
}
