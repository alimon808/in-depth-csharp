using System;
using System.Collections.Generic;

namespace CSharp.Collections
{
    public class BasicSortedSet
    {
        public SortedSet<string> BigCities()
        {
            var bigCities = new SortedSet<string>() { "New York", "Manchester", "Sheffield", "Paris" };

            bigCities.Add("Sheffield");
            bigCities.Add("Beijing");

            return bigCities;
        }
    }
}
