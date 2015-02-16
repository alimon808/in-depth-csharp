using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class RegularExpressionBasic
    {
        [Test]
        public void SimplePattern()
        {
            Regex pattern = new Regex(" ");
            string text = "Jon Skeet";
            string[] words = pattern.Split(text);
            Assert.AreEqual("Jon", words[0]);
            Assert.AreEqual("Skeet", words[1]);
        }

        [Test]
        public void NumberSeparatedString()
        {
            string patternText = @"\d";

            Regex pattern = new Regex(patternText);
            string text = "Jon0Skeet1Rob2Connery";
            string[] words = pattern.Split(text);
            Assert.AreEqual("Jon", words[0]);
            Assert.AreEqual("Skeet", words[1]);
            Assert.AreEqual("Rob", words[2]);
            Assert.AreEqual("Connery", words[3]);
        }

        [Test]
        public void SampleLogFile()
        {
            string sampleLine = "WARNING 05/10/2011 13:15:15.000 ---FooBar--- The foo has been barred";
            Regex pattern = new Regex(@"(?<level>\S+) " +
                                      @"(?<timestamp>\d{2}/\d{2}/\d{4} \d{2}:\d{2}:\d{2}\.\d{3}) " +
                                      @"---(?<category>[^-]+)--- " +
                                      @"(?<message>.*)");
            Match match = pattern.Match(sampleLine);
            Assert.AreEqual(true, match.Success);
            Assert.AreEqual("WARNING", match.Groups["level"].Value);
            Assert.AreEqual("FooBar", match.Groups["category"].Value);
        }

        [Test]
        public void RemoveVowels()
        {
            string sampleLine = "Hello, World";
            Regex pattern = new Regex("[aeiou]");
            string noVowels = pattern.Replace(sampleLine, "");
            Assert.AreEqual("Hll, Wrld", noVowels);
        }

        [Test]
        public void EncodedString()
        {
            // basic multilingual plane (bmp)
            // range of char: 0 - 65535
            // 
            // string AB = "AB";

            //string text = "Cafe/";
            //Assert.AreEqual("/efaC", Reverse(text));

            Encoding encoding = Encoding.UTF8;
            string text = "ABC";
            byte[] binary = encoding.GetBytes(text);
            Assert.AreEqual(65, binary[0]);
            Assert.AreEqual(66, binary[1]);
            Assert.AreEqual(67, binary[2]);

            string reconstituted = Encoding.Unicode.GetString(binary);
            Assert.AreEqual(text, reconstituted);
        }

        [Test]
        public void CrytoEncodedString()
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] hash = md5.ComputeHash(new byte[10]);
            }
        }

        private static string Reverse(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        const string MailHeader = "MAIL";
        [Test]
        public void Culture()
        {
            string header = "mail";
            Assert.AreEqual(MailHeader, header.ToUpper());

            CultureInfo turkish = CultureInfo.CreateSpecificCulture("tr");
            Thread.CurrentThread.CurrentCulture = turkish;

            bool isMailHeader = header.Equals(MailHeader, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(isMailHeader);

            Assert.AreEqual(MailHeader, header.ToUpperInvariant());
        }
    }
}
