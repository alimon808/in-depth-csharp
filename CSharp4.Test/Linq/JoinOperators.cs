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
    public class JoinOperators
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
        public void ShouldTestJoinOperator()
        {
            var query = employees.Join(
                           departments,
                           e => e.DepartmentId,
                           d => d.Id,
                           (e, d) => new
                           {
                               EmployeeName = e.Name,
                               DepartmentName = d.Name
                           });

            foreach (var item in query)
            {
                Console.WriteLine("{0} : {1}", item.DepartmentName, item.EmployeeName);
            }
        }

        [Test]
        public void ShouldTestGroupJoinOperator()
        {
            var query = departments.GroupJoin(
               employees,
               d => d.Id,
               e => e.DepartmentId,
               (d, eg) => new
               {
                   DepartmentName = d.Name,
                   Employees = eg
               });

            foreach (var item in query)
            {
                //Console.WriteLine(item);
                Console.WriteLine("{0}", item.DepartmentName);
                foreach (var e in item.Employees)
                {
                    Console.WriteLine(e.Name);
                }
            }
        }
    }
}
