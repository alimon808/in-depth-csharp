using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp3.LINQ.Tests
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void ShouldTestStringExtensions()
        {
            var source = "the return of the king";
            var expected = "The Return Of The King";

            // normal static method
            //var result = StringExtensions.ConvertToTitleCase(source);

            // extension methods
            var result = source.ConvertToTitleCase();

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
