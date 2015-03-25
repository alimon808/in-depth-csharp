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
    public class GroupingOperatorsTests
    {
        List<Employee> employees;
        List<Department> departments;

        [SetUp]
        public void Setup()
        {
            employees = new List<Employee> 
                            { 
                                new Employee{ Id=1, Name="Scott", DepartmentId=1},
                                new Employee{ Id=2, Name="Bill", DepartmentId=1},
                                new Employee{ Id=3, Name="Ted", DepartmentId=2},
                            };
            departments = new List<Department> 
                                {
                                    new Department {Id=1, Name = "Engineering"},
                                    new Department {Id =2, Name = "Sales"},
                                    new Department {Id = 3, Name = "Skunkworks"},
                                };
        }

        [Test]
        public void ShouldTestGroupByOperator()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query = numbers.GroupBy(i => i % 2);
            foreach (var group in query)
            {
                Console.WriteLine("Key: {0}", group.Key);
                foreach (var number in group)
                {
                    Console.WriteLine(number);
                }
            }

            //var query1 = from e in employees group e by e.DepartmentId;
            var query1 = employees.GroupBy(e => e.DepartmentId)
                                  .Select(eg => new { DepartmentId = eg.Key, Employees = eg });

            foreach (var group in query1)
            {
                Console.WriteLine("Key: {0}", group.DepartmentId);
                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name);
                }
            }

        }

        [Test]
        public void ShouldTestToLookupOperator()
        {
            var query1 = employees.ToLookup(e => e.DepartmentId)
                                  .Select(eg => new { DepartmentId = eg.Key, Employees = eg });

            foreach (var group in query1)
            {
                Console.WriteLine("Key: {0}", group.DepartmentId);
                foreach (var employee in group.Employees)
                {
                    Console.WriteLine(employee.Name);
                }
            }

        }
    }
}
