using System;
using System.Collections.Generic;
using CSharp.Collections;
using NUnit.Framework;

namespace CSharp.CollectionsTests
{
    [TestFixture]
    public class BasicMultiDimensionalArrayTests
    {
        [Test]
        public void ShouldPrintOutTemperature2D()
        {
            var sut = new BasicMultiDimensionalArray();
            var grid = sut.Temperature2D();

            Assert.That(2, Is.EqualTo(grid.Rank));

            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    Console.Write(grid[x,y] + ", ");
                }
                //Console.WriteLine();
            }
        }

        [Test]
        public void ShouldPrintOutTemperatureJagged()
        {
            var sut = new BasicMultiDimensionalArray();
            var grid = sut.TemperatureJagged();

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(grid[x][y] + ", ");
                }
                //Console.WriteLine();
            }
        }
    }
}
