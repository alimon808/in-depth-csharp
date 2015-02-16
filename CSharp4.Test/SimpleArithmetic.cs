using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class SimpleArithmetic
    {
        [Test]
        public void Add()
        {
            Assert.AreEqual(10, 5 + 5);
            Assert.AreEqual(11, 5 + 5);
        }
    }
}
