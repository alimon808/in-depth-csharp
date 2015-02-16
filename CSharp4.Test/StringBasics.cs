using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class StringBasics
    {
        [Test]
        public void Length()
        {
            string x = "hello";
            Assert.AreEqual(5, x.Length);
        }

        [Test]
        public void Immutable()
        {
            string x = "hello";
            x.Replace('h', 'j');
            Assert.AreEqual("hello", x);

            x = x.Replace('h', 'j');
            Assert.AreEqual("jello", x);
        }

        [Test]
        public void DifferentEqualObjects()
        {
            string x = "hello";
            x = x.Replace('h', 'j');
            object o1 = x;
            object o2 = "jello";
            Assert.AreNotSame(o1, o2);
            Assert.IsFalse(o1 == o2);

        }

        [Test]
        public void DifferentEqualStrings()
        {
            string x = "hello";
            x = x.Replace('h', 'j');
            string s1 = x;
            string s2 = "jello";
            Assert.AreNotSame(s1, s2);
            Assert.IsTrue(s1 == s2);
            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(object.Equals(s1, s2));
        }

        [Test]
        public void InterningOfConstants()
        {
            string x = "hello";
            string y = "hello";
            Assert.AreSame(x, y);
        }

        [Test]
        public void InterningOfConcatenation()
        {
            string x = "hello";
            string y = "he" + "llo";
            Assert.AreSame(x, y);
        }

        [Test]
        public void NonInterningOfNonConstants()
        {
            string he = "he";
            string x = "hello";
            string y = he + "llo";
            Assert.AreNotSame(x, y);
            Assert.AreEqual(x, y);
        }

        [Test]
        public void BadConcatenation()
        {
            string simple = new string('x', 1000);
            string bad = "";
            for (int i = 0; i < 1000; i++)
            {
                bad = bad + "x";
            }

            Assert.AreEqual(simple, bad);
        }

        [Test]
        public void GoodConcatenation()
        {
            string simple = new string('x', 100000);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append("x");
            }
            string good = sb.ToString();
            Assert.AreEqual(simple, good);
        }

        [Test]
        public void BadUseOfStringBuilder()
        {
            string x = "x";
            string y = "y";
            // we want x = " " + y;
            StringBuilder sb = new StringBuilder();
            sb.Append(x);
            sb.Append(" ");
            sb.Append(y);
            string result = sb.ToString();
            Assert.AreEqual("x y", result);
        }

        [Test]
        public void StringJoin()
        {
            string[] values = { "x", " ", "y" };
            string commaSeparated = string.Join(",", values);
            Assert.AreEqual("x, ,y", commaSeparated);
        }

        [Test]
        public void StringFormat()
        {
            string x = "x";
            string y = "y";
            string result = string.Format("{0} {1}", x, y);
            Assert.AreEqual("x y", result);
        }

        [Test]
        public void StringFormat2()
        {
            string x = "x";
            string y = "y";
            string result = string.Format("{1} {0}", x, y);
            Assert.AreEqual("y x", result);
        }


        [Test]
        public void StringFormat3()
        {
            int x = 100;
            string y = "y";
            string result = string.Format("x={0} y={1}", x, y);
            Assert.AreEqual("x=100 y=y", result);
        }


        [Test]
        public void StringFormat5()
        {
            decimal price = 10.50m;
            string result = string.Format("price={0:c}", price);
            Assert.AreEqual("price=$10.50", result);
        }
    }
}
