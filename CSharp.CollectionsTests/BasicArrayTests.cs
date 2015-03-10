using System;
using CSharp.Collections;
using NUnit.Framework;


namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class BasicArrayTests
    {
        [Test]
        public void ShouldReturnSevenDaysInAWeek()
        {
            var sut = new BasicArray();

            Assert.That(7, Is.EqualTo(sut.DaysOfTheWeek().Length));
        }

        [Test]
        public void ShouldReturnMondayAsTheFirstElementInTheArray()
        {

            var sut = new BasicArray();
            var daysOfTheWeek = sut.DaysOfTheWeek();

            Assert.That(daysOfTheWeek[0], Is.EqualTo("Monday"));
        }

        [Test]
        public void ShouldEnumerateArray()
        {
            var sut = new BasicArray();
            sut.EnumerateDaysOfTheWeek();
        }

        [Test]
        public void ShouldChangePersonInArray() 
        {
            var sut = new BasicArray();
            sut.InsideArrayChangePerson();
        }

        [Test]
        public void ShouldTestArrayAsReferenceTypes()
        {
            var sut = new BasicArray();
            sut.AsReferenceTypes();
        }

        [Test]
        public void ShouldTestArrayCovariance()
        {
            var sut = new BasicArray();
            sut.ArrayCovariance();
        }

        [Test]
        public void ShouldTestArrayCopy()
        {
            var sut = new BasicArray();
            sut.ArrayCopy();
        }

        [Test]
        public void ShouldTestArraySort()
        {
            var sut = new BasicArray();
            sut.ArraySort();
        }
    }
}
