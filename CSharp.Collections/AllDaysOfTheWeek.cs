using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp.Collections
{
    public class AllDaysOfTheWeek : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("Calling generic GetEnumerator");
            yield return "Monday";
            yield return "Tuesday";
            yield return "Wednesday";
            yield return "Thursday";
            yield return "Friday";
            yield return "Saturday";
            yield return "Sunday";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
