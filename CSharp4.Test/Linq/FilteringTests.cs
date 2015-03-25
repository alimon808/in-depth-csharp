using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    public class FilteringTests
    {
        [Test]
        public void ShouldTestWhereOperator()
        {
            object[] things = { "Glasses", "Books" };

            var query = things.Where(t => t.ToString().Length == 5).ToList();
            Assert.That(query.Count, Is.EqualTo(1));
        }

        [Test]
        public void ShouldTestOfTypeOperator()
        {
            object[] things = { "Glasses", 2, "Books" };
            ArrayList listOfThings = new ArrayList(things);

            var ints = listOfThings.OfType<int>();
            Assert.That(ints.Count(), Is.EqualTo(1));

            var strings = listOfThings.OfType<string>();
            Assert.That(strings.Count(), Is.EqualTo(2));
        }
    }
}
