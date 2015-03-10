using System;
using System.Collections.Generic;
using CSharp.Collections;
using NUnit.Framework;

namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class BasicEnumeratorTests
    {
        [Test]
        public void ShouldPrintOutDaysOfTheWeek()
        {
            var sut = new BasicEnumerator();
            var days = sut.DaysOfTheWeek();

            BasicEnumerator.DisplayItems(days);
        }

        [Test]
        public void ShouldPrintOutDaysOfTheWeekUsingForEach()
        {
            var sut = new BasicEnumerator();
            var days = sut.DaysOfTheWeek();

            BasicEnumerator.DisplayItemsUsingForEach(days);
        }
    }
}
