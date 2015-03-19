using System;
using System.Collections.Generic;
using System.Linq;
using CSharp4.Linq;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    public class EmployeeTests
    {
        private List<Employee> employees = new List<Employee>();

        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine("Before {0}", TestContext.CurrentContext.Test.Name);
            employees.Add(new Employee { Id = 1, Name = "Scott", HireDate = new DateTime(2002, 3, 5) });
            employees.Add(new Employee { Id = 2, Name = "Poonam", HireDate = new DateTime(2002, 10, 15) });
            employees.Add(new Employee { Id = 3, Name = "Paul", HireDate = new DateTime(2007, 10, 11) });
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine("After {0}", TestContext.CurrentContext.Test.Name);
            employees.Clear();
        }

        [Test]
        public void ShouldReturnThreeEmployees()
        {
            Assert.That(employees.Count, Is.EqualTo(3));
        }

        [Test]
        public void ShouldGetEmployeesHiredBefore2005()
        {
            IEnumerable<Employee> query = from e in employees
                                          where e.HireDate.Year < 2005
                                          orderby e.Name
                                          select e;
            foreach (var e in query)
            {
                Console.WriteLine(e.Name);
            }

            Assert.That(query.ToList().Count, Is.EqualTo(2));
        }

        [Test]
        public void ShouldTestComprehensionQuerySyntax()
        {
            // comprehension query syntax
            IEnumerable<Employee> query1 = from e in employees
                                           where e.Name == "Scott"
                                           orderby e.Id ascending
                                           select e;

            // extension methods syntax
            IEnumerable<Employee> query2 = employees.Where(e => e.Name == "Scott")
                                                    .OrderBy(e => e.Id);
        }

        [Test]
        public void ShouldTestImplicitTyping()
        {
            var name = "Scott";
            Assert.That(name is string, Is.True);

            var x = 3.0;
            Assert.That(x is double, Is.True);

            var y = 2;
            Assert.That(y is int, Is.True);

            var z = x * y;
            Assert.That(z is double, Is.True);
        }

        [Test]
        public void ShouldTestAnonymousTypes()
        {
            var employee = new { Name = "Scott", Department = "Engineering" };
            Assert.That(employee.Name, Is.EqualTo("Scott"));
            Assert.That(employee.Department, Is.EqualTo("Engineering"));
        }
    }
}
