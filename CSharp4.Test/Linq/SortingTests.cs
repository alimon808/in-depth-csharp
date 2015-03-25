using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    public class SortingTests
    {
        [Test]
        public void ShouldTestOrderBy()
        {
            var query = Process.GetProcesses().OrderBy(p => p.WorkingSet64);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void ShouldTestThenBy()
        {
            var query = Process.GetProcesses()
                               .OrderBy(p => p.WorkingSet64)
                               .ThenBy(p => p.Threads.Count);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            
        }

        //private void DisplayCollection(IEnumerable<T> collection)
        //{
        //    foreach (var item in collection)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
    }
}
