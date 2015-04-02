using System;
using System.Collections.Generic;
using System.Linq;
using CSharp4.Linq;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    public class ContactTests
    {
        [Test]
        public void ShouldTestSampleContactData() {
            List<Contact> contacts = new Contact().SampleData();
            var query = from c in contacts
                        where c.DateOfBirth.AddYears(40) > DateTime.Now
                        orderby c.DateOfBirth descending
                        select string.Format("{0} {1} b.{2}", c.FirstName, c.LastName, c.DateOfBirth.ToString("dd-MMM-yyyy"));


            foreach (string s in query)
            {
                Console.WriteLine(s);
            }

            var queryGroup = from c in contacts
                             group c by c.State;

            foreach (var group in queryGroup)
            {
                Console.WriteLine("State: " + group.Key);
                foreach (var c in group)
                {
                    Console.WriteLine("    {0} {1}", c.FirstName, c.LastName);
                }
            }
        }

    }
}
