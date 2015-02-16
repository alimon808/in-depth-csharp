using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test
{
    [TestFixture]
    public class DateTimeBasics
    {
        [Test]
        public void DateTimeUsage()  // .NET 1.0
        {
            DateTime jonsTime = new DateTime(2011, 4, 1, 21, 24, 0, DateTimeKind.Local);
            DateTime robsTime = new DateTime(2011, 4, 1, 10, 24, 0, DateTimeKind.Local);
            DateTime utcTime = new DateTime(2011, 4, 1, 20, 24, 0, DateTimeKind.Utc);
            DateTime unspecified = new DateTime(2011, 4, 1, 21, 24, 0, DateTimeKind.Unspecified);

            Assert.AreEqual(utcTime, utcTime.ToUniversalTime());


        }

        [Test]
        public void TimeSpanUsage()  // .NET 1.0
        {
            TimeSpan fiveSeconds = TimeSpan.FromSeconds(5);
            TimeSpan halfAMinute = TimeSpan.FromMinutes(.5);
            Assert.AreEqual(TimeSpan.FromMilliseconds(35000), fiveSeconds + halfAMinute);
            
        }

        [Test]
        public void DateTimeOffsetUsage()  // .NET 2.0SP1 / .NET 3.5
        {
            DateTimeOffset jonsTime = new DateTimeOffset(2011, 4, 1, 21, 24, 0, TimeSpan.FromHours(1));


        }

        [Test]
        public void TimeZoneInfoUsage()  // .NET 3.5
        {
            TimeZoneInfo zone = TimeZoneInfo.Local;
            Assert.AreEqual(TimeSpan.FromHours(-7),
                             zone.GetUtcOffset(new DateTime(2011, 3, 27, 0, 0, 0)));

            Assert.AreEqual(TimeSpan.FromHours(-7),
                            zone.GetUtcOffset(new DateTime(2011, 3, 27, 3, 0, 0)));

            Console.WriteLine(zone.GetUtcOffset(new DateTime(2011, 3, 27, 3, 0, 0)));
        }
    }
}
