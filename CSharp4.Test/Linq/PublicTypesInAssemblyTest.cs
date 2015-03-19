using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    class PublicTypesInAssemblyTest
    {
        [Test]
        public void ShouldDisplayAllPublicTypesInCurrentAssembly()
        {
            IEnumerable<string> publicTypes =
                from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.IsPublic
                select t.FullName;

            foreach (var name in publicTypes)
            {
                Console.WriteLine(name);
            }
        }
    }
}
