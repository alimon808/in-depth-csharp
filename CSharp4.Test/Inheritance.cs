using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class BaseClassTest
    {
        [Test]
        public void CalculateResultTest()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(16, test.CalculateResult(8));

        }

        [Test]
        public void TrebleInputTest()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual(9, test.TrebleInput(3));
        }

        [Test]
        public void NameDefaultsTest()
        {
            BaseClass test = new BaseClass();
            Assert.AreEqual("default", test.Name);
        }
        [Test]
        public void NameDefaultsTest2()
        {
            BaseClass test = new BaseClass("Jon");
            Assert.AreEqual("Jon", test.Name);
        }
    }

    


}
