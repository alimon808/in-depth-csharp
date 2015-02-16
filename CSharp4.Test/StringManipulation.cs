using System;
using System.Text;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class StringManipulation
    {
        [Test]
        public void Substring()
        {
            string x = "hello";
            string y = x.Substring(1, 3);

            Assert.AreEqual("ell", y);

            string z = x.Substring(2);
            Assert.AreEqual("llo", z);
        }

        [Test]
        public void Find()
        {
            string x = "hello";
            int firstEllIndex = x.IndexOf('l');
            Assert.AreEqual(2, firstEllIndex);

            int secondEllIndex = x.IndexOf('l', firstEllIndex + 1);
            Assert.AreEqual(3, secondEllIndex);

            int thirdEllIndex = x.IndexOf('l', secondEllIndex + 1);
            Assert.AreEqual(-1, thirdEllIndex);


        }

        [Test]
        public void FindDelimeter()
        {
            string x = "Jon Skeet";
            int spaceIndex = x.IndexOf(' ');
            string first = x.Substring(0, spaceIndex);
            Assert.AreEqual("Jon", first);

            string last = x.Substring(spaceIndex + 1);
            Assert.AreEqual("Skeet", last);
        }

        [Test]
        public void Split()
        {
            string x = "Jon Skeet-Webb";
            // equivalent to x.Split(new char[]{' ', '-', '|'}
            string[] words = x.Split(' ', '-', '|');

            Assert.AreEqual(3, words.Length);
            Assert.AreEqual("Jon", words[0]);
            Assert.AreEqual("Skeet", words[1]);
            Assert.AreEqual("Webb", words[2]);
        }

        [Test]
        public void SplitCSV()
        {
            string x = "0,1,,3,,5,,7";
            string[] words = x.Split(',');

            Assert.AreEqual(8, words.Length);

            string[] removeEmpty = x.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(5, removeEmpty.Length);
        }
    }
}
