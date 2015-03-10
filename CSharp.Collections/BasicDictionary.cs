using System;
using System.Collections.Generic;


namespace CSharp.Collections
{
    public class BasicDictionary
    {
        public Dictionary<string,PrimeMinister> PrimeMinisters()
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>(new UncasedStringEqualityComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };

            return primeMinisters;
        }
    }
}
