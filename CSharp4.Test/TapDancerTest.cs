using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class TapDancerTest
    {
        [Test]
        public void NameDefaults()
        {
            Dancer dancer = new TapDancer();
            Assert.AreEqual("My tap dancer", dancer.Name);
        }

        [Test]
        public void DanceBabyDance()
        {
            Dancer dancer = new TapDancer();
            dancer.Dance();
        }

        [Test]
        public void DanceTwice()
        {
            Dancer dance = new TapDancer();
            dance.DanceTwice();
        }
    }
}
