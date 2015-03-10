using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Collections
{
    public class BasicHashSet
    {
        public List<string> ListBigCities()
        {
            var bigCities = new List<string>() { 
            
                "New York",
                "Manchester",
                "Sheffield",
                "Paris",
            };

            bigCities.Add("Sheffield");
            bigCities.Add("Beijing");

            return bigCities;
        }

        // hashset guarantees uniqueness
        // only one sheffield element
        public HashSet<string> HashBigCities()
        {
            var bigCities = new HashSet<string>()
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris",
            };

            bigCities.Add("Sheffield");
            bigCities.Add("Beijing");

            return bigCities;
        }

        public HashSet<string> HashBigCitiesIgnoreCase()
        {
            var bigCities = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris",
            };

            bigCities.Add("SHEFFIELD");
            bigCities.Add("BEIJING");

            return bigCities;
        }

        public HashSet<string> HashBigCitiesIgnoreCaseUsingCustomEqualityComparer()
        {
            var bigCities = new HashSet<string>(new UncasedStringEqualityComparer())
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris",
            };

            bigCities.Add("SHEFFIELD");
            bigCities.Add("BEIJING");

            return bigCities;
        }


        // set operation: intersection
        public HashSet<string> HashBigCitiesInUK()
        {
            var bigCities = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris",
            };

            string[] citiesInUK = { "Sheffield", "Ripon", "Truro", "Manchester" };

            // modify collection
            // accepts any collection
            bigCities.IntersectWith(citiesInUK);

            return bigCities;
        }

        public IEnumerable<string> EnumerableBigCitiesInUK()
        {
            var bigCities = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris",
            };

            string[] citiesInUK = { "Sheffield", "Ripon", "Truro", "Manchester" };

            var ukCities = bigCities.Intersect(citiesInUK);
            return ukCities;
        }

        // union
        public HashSet<string> BigCitiesInUKAndTheWorld()
        {
            var bigCities = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris",
            };

            string[] citiesInUK = { "Sheffield", "Ripon", "Truro", "Manchester" };

            bigCities.UnionWith(citiesInUK);
            return bigCities;
        }

        // symmetric difference set operation
        public HashSet<string> BigCitiesSymmetricDifference()
        {
            var bigCities = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris",
            };

            string[] citiesInUK = { "Sheffield", "Ripon", "Truro", "Manchester" };

            // New York, Paris, Ripon, Truro
            bigCities.SymmetricExceptWith(citiesInUK);
            return bigCities;
        }

        // difference set operation
        public HashSet<string> BigCitiesDifference()
        {
            var bigCities = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase)
            {
                "New York",
                "Manchester",
                "Sheffield",
                "Paris",
            };

            string[] citiesInUK = { "Sheffield", "Ripon", "Truro", "Manchester" };

            // New York, Paris
            bigCities.ExceptWith(citiesInUK);
            return bigCities;
        }
    }
}
