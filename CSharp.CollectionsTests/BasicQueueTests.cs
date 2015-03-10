using System;
using System.Collections.Generic;
using CSharp.Collections;
using NUnit.Framework;

namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class BasicQueueTests
    {
        [Test]
        public void ShouldTestBasicQueue()
        {
            var sut = new BasicQueue();
            var tasks = sut.Tasks();
            Assert.That(4, Is.EqualTo(tasks.Count));

            var nextTask = tasks.Dequeue();
            Assert.That(3, Is.EqualTo(tasks.Count));
            Assert.That(nextTask, Is.EqualTo("Do the washing up"));

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
