using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class DerivedClassTest
    {
        [Test]
        public void DefaultName()
        {
            BaseClass test = new DerivedClass();
            Assert.AreEqual("derived default", test.Name);
        }

        [Test]
        public void SpecifiedName()
        {
            BaseClass test = new DerivedClass("Jon");
            Assert.AreEqual("derived Jon", test.Name);
        }

        [Test]
        public void QuadrupleTest()
        {
            DerivedClass test = new DerivedClass();
            Assert.AreEqual(20, test.Quadruple(5));
        }

        [Test]
        public void TrebleTest()
        {
            BaseClass test = new DerivedClass();
            Assert.AreEqual(15, test.TrebleInput(5));
        }

        [Test]
        public void CalculateResultHalvesInput()
        {
            BaseClass test = new DerivedClass();
            Assert.AreEqual(4, test.CalculateResult(8));
        }
    }
}
