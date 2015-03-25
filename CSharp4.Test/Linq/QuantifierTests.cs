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
    public class QuantifierTests
    {
        int[] twos;

        [SetUp]
        public void SetUp()
        {
            twos = new[] {2, 4, 6, 8, 10};
        }

        [Test]
        public void ShouldTestAllQuantifier()
        {
            var areAllEvenNumbers = twos.All(i => i % 2 == 0);
            Assert.That(areAllEvenNumbers, Is.True);
        }

        [Test]
        public void ShouldTestAnyQuantifier()
        {
            var containsMultipleofThree = twos.Any(i => i % 3 == 0);
            Assert.That(containsMultipleofThree, Is.True);
        }

        [Test]
        public void ShouldTestContainsQuantifier()
        {
            var hasSeven = twos.Contains(7);
            Assert.That(hasSeven, Is.False);
        }

        [Test]
        public void ShouldTestEmployeeValidationRules()
        {
            Employee employee = new Employee { Id = 1, Name = "Herman" };

            var employeeValidationRules = new List<Func<Employee, bool>>()
            {
                e => !String.IsNullOrEmpty(e.Name)
            };

            bool isEmployeeValid = employeeValidationRules.All(rule => rule(employee));
        }
    }
}
