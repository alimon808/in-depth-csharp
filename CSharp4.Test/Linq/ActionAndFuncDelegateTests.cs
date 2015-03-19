using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    class ActionAndFuncDelegateTests
    {
        [Test]
        public void ShouldTestActionDelegate()
        {
            Action printEmptyLine = () => Console.WriteLine();
            Action<int> printNumber = (x) => Console.WriteLine(x);
            Action<int, int> printTwoNumbers = (x, y) => { Console.WriteLine(x); Console.WriteLine(y); };

            printEmptyLine();
            printNumber(3);
            printTwoNumbers(5, 10);
        }

        [Test]
        public void ShouldTestFuncDelegate()
        {
            Func<DateTime> getTime = () => DateTime.Now;
            Func<int, int> square = x => x * x;
            Func<int, int, int> multiply = (x, y) => x * y;

            DateTime now = getTime();
            int z = multiply(5, 15);
        }

        [Test]
        public void ShouldTestExpressions()
        {
            Expression<Func<int, int, int>> multiply = (x, y) => x * y;

            Func<int, int, int> mult = multiply.Compile();
            int z = mult(5, 15);
            Console.WriteLine(z);
        }
    }
}
