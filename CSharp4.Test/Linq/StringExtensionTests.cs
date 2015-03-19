using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharp4.Linq;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    public class StringExtensionTests
    {
        [Test]
        public void ShouldBeValidZipCode()
        {
            var zipCode = "21740";
            var result = zipCode.IsValidPostalCode();
            Assert.That(result, Is.True);
        }
    }
}
