using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class ControlFlowBasics
    {
        [Test]
        public void Return()
        {
            Console.WriteLine("Hello");
            return;
        }

        [Test]
        public int ReturningInt32()
        {
            return 15;
        }

        [Test]
        public void If()
        {
            int x = 10;
            if (x > 5)
            {
                Console.WriteLine("x is greater than 5");
            }

            if (x < 5)
            {
                Console.WriteLine("x is less than 5");
            }
            else
            {
                Console.WriteLine("x is not less than 5");
            }
        }
    }
}
