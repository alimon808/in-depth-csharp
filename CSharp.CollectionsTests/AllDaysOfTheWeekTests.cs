using System;
using System.Collections.Generic;
using CSharp.Collections;
using NUnit.Framework;

namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class AllDaysOfTheWeekTests
    {
        [Test]
        public void ShouldPrintAllDaysOfTheWeekUsingCustomEnumerator()
        {
            var days = new AllDaysOfTheWeek();
            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }
    }
}
