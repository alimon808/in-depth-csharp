using System;
using System.Collections.Generic;
using CSharp.Collections;
using NUnit.Framework;

namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class BasicDictionaryTests
    {
        [Test]
        public void ShouldTestBasicDictionary()
        {
            var sut = new BasicDictionary();
            var primeMinisters = sut.PrimeMinisters();

            Assert.That(3, Is.EqualTo(primeMinisters.Count));

            PrimeMinister tb = primeMinisters["tb"];
            Assert.That(tb.Name, Is.EqualTo("Tony Blair"));

            PrimeMinister dc;
            bool found = primeMinisters.TryGetValue("DC", out dc);
            Assert.That(found, Is.False);

            // update dictionary key value
            primeMinisters["JC"] = new PrimeMinister("Jim Callahan", 1976);
            // add pm
            primeMinisters.Add("GB", new PrimeMinister("Gordon Brown", 2007));
            Assert.That(4, Is.EqualTo(primeMinisters.Count));


            foreach (var pm in primeMinisters)
            {
                Console.WriteLine(pm.Key + ", " + pm.Value);
            }
        }

        [Test]
        public void ShouldTestPrimeMinistersByYearDictionary()
        {
            var primeMinisters = new PrimeMinistersByYearDictionary()
            {
                new PrimeMinister("James Callaghan", 1974),
                new PrimeMinister("Margaret Thatcher", 1979),
                new PrimeMinister("Tony Blair", 1997)
            };

            primeMinisters.Add(new PrimeMinister("John Major", 1990));

            Assert.That(4, Is.EqualTo(primeMinisters.Count));

            PrintCollection(primeMinisters as ICollection<PrimeMinister>);

        }

        private void PrintCollection(ICollection<PrimeMinister> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
