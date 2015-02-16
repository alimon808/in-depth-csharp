using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class AnonymousTypes
    {
        [Test]
        public void Demo()
        {
            var person1 = new { FirstName = "Jon", LastName = "Skeet" };
            var person2 = new { FirstName = "Jon", LastName = "Skeet" };
            Assert.AreEqual(person1, person2);
            Assert.AreEqual(person1.GetHashCode(), person2.GetHashCode());
        }
    }
}
