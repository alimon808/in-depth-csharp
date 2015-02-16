using System;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class SimpleTypes
    {
        [Test]
        public void DisplayValues()
        {
            /*
             * int = System.Int32
             * uint = System.UInt32
             * 
             * long = System.Int64
             * ulong = System.UInt64
             * 
             * byte = System.Byte (8 bits)
             * sbyte = System.SByte (8 bits)
             * 
             * short = System.Int16
             * ushort = System.UInt16
             * 
             * float = System.Single (32 bits)
             * double = System.Double (64 bits)
             * decimal = System.Decimal (128 bits)
             * 
             * sign: 0 (positive/zero) or 1 (negative)
             * exponent (or power)
             * mantissa
             * 
             * 
             */

            int x = 10;
            int y = x++;

            Assert.AreEqual(10, y);

            float v1 = 0.2f;
            double v2 = 0.2;
            decimal v3 = 0.3m;

        }
    }
}
