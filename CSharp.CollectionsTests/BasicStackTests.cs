using System;
using System.Collections.Generic;
using CSharp.Collections;
using NUnit.Framework;

namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class BasicStackTests
    {
        [Test]
        public void ShouldTestBasicStack()
        {
            var sut = new BasicStack();
            var books = sut.Books();

            Assert.That(4, Is.EqualTo(books.Count));

            string topItem = books.Pop();

            Assert.That(topItem, Is.EqualTo("Harry Potter and the Chamber of Secrets"));
            Assert.That(3, Is.EqualTo(books.Count));

            string peek = books.Peek();
            Assert.That(3, Is.EqualTo(books.Count));


            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
