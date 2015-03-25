using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp4.Linq;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    public class Rule<T>
    {
        public Func<T, bool> Test { get; set; }
        public string Message { get; set; }
    }
    [TestFixture]
    public class AggregationTests
    {
        [Test]
        public void ShouldTestAggreationOperators()
        {
            Process[] runningProcesses = Process.GetProcesses();
            var summary = new
            {
                ProcessCount = runningProcesses.Count(),
                WorkerProcessCount = runningProcesses.Count(p => p.ProcessName == "w3wp"),
                TotalThreads = runningProcesses.Sum(p => p.Threads.Count),
                MinThreads = runningProcesses.Min(p => p.Threads.Count),
                MaxThreads = runningProcesses.Max(p => p.Threads.Count),
                AvgThreads = runningProcesses.Average(p => p.Threads.Count)
            };
            Console.WriteLine(summary);
        }

        [Test]
        public void ShouldTestAggregateOperator()
        {
            Employee employee = new Employee();

            var rules = new List<Rule<Employee>>()
            {
                new Rule<Employee> 
                {
                    Test = e => !String.IsNullOrEmpty(e.Name),
                    Message = "Employee name cannot be empty"
                },

                new Rule<Employee> 
                {
                    Test = e => e.DepartmentId > 0,
                    Message = "Employee must have an assigned department"
                },

                new Rule<Employee>
                {
                    Test = e => e.Id > 0,
                    Message = "Employee must have an Id"
                }
            };

            bool isValid = rules.All(r => r.Test(employee));

            Assert.That(isValid, Is.False);

            if (!isValid)
            {
                var failedrules = rules.Where(r => r.Test(employee) == false);
                string errorMessage = failedrules.Aggregate(new StringBuilder(), 
                                                            (sb, r) => sb.AppendLine(r.Message), 
                                                            sb => sb.ToString());
                Console.WriteLine(errorMessage);
            }
        }
    }
}
