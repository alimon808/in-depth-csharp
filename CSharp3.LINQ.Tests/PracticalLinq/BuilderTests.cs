using System;
using NUnit.Framework;

namespace CSharp3.LINQ.Tests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void ShouldBuildIntegerSequence()
        {
            var sut = new Builder();

            var integers = sut.BuilderIntegerSequence();

            foreach (var item in integers)
            {
                Console.WriteLine(item.ToString());
            }

            Assert.That(integers, Is.Not.Null);
        }

        [Test]
        public void ShouldBuildStringSequence()
        {
            var sut = new Builder();

            var strings = sut.BuilderStringSequence();

            foreach (var item in strings)
            {
                Console.WriteLine(item.ToString());
            }

            Assert.That(strings, Is.Not.Null);
        }

        [Test]
        public void ShouldBuildRandomStringSequence()
        {
            var sut = new Builder();

            var strings = sut.BuilderRandomStringSequence();

            foreach (var item in strings)
            {
                Console.WriteLine(item.ToString());
            }

            Assert.That(strings, Is.Not.Null);
        }

        [Test]
        public void ShouldBuildIntersectSequence()
        {
            var sut = new Builder();
            var result = sut.IntersectSequences();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void ShouldBuildExceptSequence()
        {
            var sut = new Builder();
            var result = sut.ExceptSequences();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void ShouldBuildConcatSequence()
        {
            var sut = new Builder();
            var result = sut.ConcatSequences();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Assert.That(result, Is.Not.Null);
        }

        [Test]
        public void ShouldBuildUnionSequence()
        {
            var sut = new Builder();
            var result = sut.UnionSequences();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Assert.That(result, Is.Not.Null);
        }
    }
}
