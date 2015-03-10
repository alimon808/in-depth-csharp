using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Collections;
using NUnit.Framework;

namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class BasicLinkedListTests
    {
        [Test]
        public void ShouldTestBasicLinkedList()
        {
            var sut = new BasicLinkedList();
            var presidents = sut.Presidents();

            Assert.That(4, Is.EqualTo(presidents.Count));

            // inefficient
            var richardNixon = presidents.Find("Richard Nixon");
            presidents.AddAfter(richardNixon, "Gerald Ford");

            Assert.That(5, Is.EqualTo(presidents.Count));


            // update JFK to John F Kennedy
            presidents.Remove("JFK");
            presidents.AddFirst("John F Kennedy");


            foreach (var president in presidents)
            {
                Console.WriteLine(president);
            }
        }
    }
}
