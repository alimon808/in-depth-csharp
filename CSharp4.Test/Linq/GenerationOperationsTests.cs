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
    public class GenerationOperationsTests
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
        public void ShouldTestEmptyGenerationOperation()
        {
            var query = from d in departments
                        join e in employees on d.Id equals e.DepartmentId
                        into eg
                        select new
                        {
                            DepartmentName = d.Name,
                            Employees = eg
                        };
        }
    }
}
