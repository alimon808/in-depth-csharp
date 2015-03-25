using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp4.Linq;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    public class EqualityTests
    {
        [Test]
        public void ShouldTestSequenceEqualOperator()
        {
            Employee e1 = new Employee { Id = 1 };
            Employee e2 = new Employee { Id = 2 };
            Employee e3 = new Employee { Id = 3 };

            var employees1 = new List<Employee>() { e1, e2, e3 };
            var employees2 = new List<Employee>() { e3, e2, e1 };

            bool result = employees1.SequenceEqual(employees2);
            Assert.That(result, Is.False);

        }
    }
}
