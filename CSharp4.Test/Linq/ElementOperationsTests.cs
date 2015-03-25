using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    public class ElementOperationsTests
    {
        string[] empty = {};
        string[] notEmpty;

        [SetUp]
        public void BeforeEachTest()
        {
            notEmpty = new[] { "Hello", "World" };
        }

        [Test]
        public void ShouldTestFirstOrDefault()
        {
            var result = empty.FirstOrDefault();
            Assert.That(result, Is.Null);

            result = notEmpty.FirstOrDefault();
            Assert.That(result, Is.EqualTo("Hello"));
        }

        [Test]
        public void ShouldTestLastOrDefault()
        {
            var result = empty.LastOrDefault();

            Assert.That(result, Is.Null);

            result = notEmpty.LastOrDefault();
            Assert.That(result, Is.EqualTo("World"));
        }

        [Test]
        public void ShouldTestElementAt()
        {
            var result = empty.ElementAtOrDefault(1);
            Assert.That(result, Is.Null);

            result = notEmpty.ElementAt(1);
            Assert.That(result, Is.EqualTo("World"));


        }

        [Test]
        public void ShouldTestSingleOrDefault()
        {
            var result = empty.SingleOrDefault();
            Assert.That(result, Is.Null);

            result = notEmpty.FirstOrDefault(s => s.StartsWith("W"));
            Assert.That(result, Is.EqualTo("World"));

            result = notEmpty.FirstOrDefault(s => s.StartsWith("Z"));
            Assert.That(result, Is.Null);
        }
    }
}
