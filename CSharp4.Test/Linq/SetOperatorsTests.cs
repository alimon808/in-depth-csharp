using System;
using System.Collections.Generic;
using System.Linq;
using CSharp4.Linq;
using NUnit.Framework;


namespace CSharp4.Test.Linq
{
    [TestFixture]
    class SetOperatorsTests
    {
        [Test]
        public void ShouldTestDistinctOperator()
        {
            int[] twos = { 2, 4, 2, 2, 10 };

            var distinct = twos.Distinct();
            Assert.That(distinct.Count(), Is.EqualTo(3));

            var employees = new List<Employee> 
            {
                new Employee {Id=1, Name = "Scott"},
                new Employee {Id=2, Name = "Poonam"},
                new Employee {Id=1, Name = "Scott"}
            };

            var query1 = employees.Distinct();
            Assert.That(query1.ToList().Count, Is.EqualTo(3));

            var query2 = employees.Select(e => new { e.Id, e.Name }).Distinct();
            Assert.That(query2.ToList().Count, Is.EqualTo(2));
        }

        [Test]
        public void ShouldTestIntersectionOperator()
        {
            int[] twos = { 2, 4, 6, 8, 10 };
            int[] threes = { 3, 6, 9, 12, 15 };

            // 6
            var intersection = twos.Intersect(threes);
            Assert.That(intersection.Count(), Is.EqualTo(1));
            Assert.That(intersection.FirstOrDefault(), Is.EqualTo(6));
        }

        [Test]
        public void ShouldTestExceptOperator()
        {
            int[] twos = { 2, 4, 6, 8, 10 };
            int[] threes = { 3, 6, 9, 12, 15 };

            // 2, 4, 8, 10
            var except = twos.Except(threes);
            Assert.That(except.Count(), Is.EqualTo(4));
            Assert.That(except.FirstOrDefault(), Is.EqualTo(2));
        }

        [Test]
        public void ShouldTestUnionOperator()
        {
            int[] twos = { 2, 4, 6, 8, 10 };
            int[] threes = { 3, 6, 9, 12, 15 };

            // 2, 4, 6, 8, 10, 3, 9, 12, 15
            var union = twos.Union(threes);
            Assert.That(union.Count(), Is.EqualTo(9));
            Assert.That(union.LastOrDefault(), Is.EqualTo(15));
        }
    }
}
