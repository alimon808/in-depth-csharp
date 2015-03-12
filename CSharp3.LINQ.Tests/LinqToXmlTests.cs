using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp3.LINQ.Tests
{
    [TestFixture]
    public class LinqToXmlTests
    {
        [Test]
        public void ShouldCreateSimpleXml()
        {
            var sut = new LinqToXml();
            sut.CreateSimpleXml();
        }

        [Test]
        public void ShouldReadSimpleXml()
        {
            var sut = new LinqToXml();
            sut.ReadSimpleXml();
        }

        [Test]
        public void ShouldDisplayTypeInfo()
        {
            var sut = new LinqToXml();
            sut.CreateTypeInfo();
        }
    }
}
