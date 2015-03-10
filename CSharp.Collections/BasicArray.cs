using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Collections
{
    public class BasicArray
    {
        public string[] DaysOfTheWeek()
        {
            string[] daysOfTheWeek = {
                                         "Monday",
                                         "Tuesday",
                                         "Wednesday",
                                         "Thursday",
                                         "Friday",
                                         "Saturday",
                                         "Sunday"
                                     };
            return daysOfTheWeek;
        }

        public void DeclareAndInitialize()
        {
            int x1;
            int[] x2;  // null

            int x3 = 5;

            // initialize array size 5 with default value 0
            int[] x4 = new int[5]; 

            // initialize array size 5 with values
            int[] x5 = new int[5] { 1, 4, 9, 16, 25 };

            // can use any expression that can be evaluated at run-time
            var eight = 8;
            int[] squares = new int[] { 1, 2 * 2, eight + 1, int.Parse("16"), (int)Math.Sqrt(625) };

            var sqaures2 = new int[] { 1, 2 * 2, eight + 1, int.Parse("16"), (int)Math.Sqrt(625) };

            int[] squares3 = { 1, 2 * 2, eight + 1, int.Parse("16"), (int)Math.Sqrt(625) };
        }

        public void EnumerateDaysOfTheWeek()
        {
            var daysOfTheWeek = DaysOfTheWeek();

            for (int i = 0; i < daysOfTheWeek.Length; i++)
            {
                Console.WriteLine(daysOfTheWeek[i]);
            }

            foreach (var day in daysOfTheWeek)
            {
                Console.WriteLine(day);
            }
        }

        public void InsideArrayChangePerson()
        {
            Person[] people = { 
                                  new Person { Name = "Bill", Age = 7 }, 
                                  new Person { Name = "Ben", Age = 8 } 
                              };

            foreach (var person in people)
            {
                person.Age = 20;
            }
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        public void AsReferenceTypes()
        {
            int[] x1 = { 1, 4, 9, 16 };
            var x2 = x1;
            int[] x3 = { 1, 4, 9, 16 };

            Console.WriteLine(string.Format("x1==x2 is {0}", x1 == x2));
            Console.WriteLine(string.Format("x1==x3 is {0}", x1 == x3));

        }

        public void ArrayCovariance()
        {
            object[] objArr = new object[3];
            string[] daysOfTheWeek = DaysOfTheWeek();

            object[] objArr2 = daysOfTheWeek;

            foreach (object obj in objArr2)
            {
                Console.WriteLine(obj);
            }
        }

        public void ArrayCopy()
        {
            int[] squares = { 1, 4, 9, 16 };
            int[] copy = new int[4];
            squares.CopyTo(copy, 0);

            foreach (var square in squares)
            {
                Console.WriteLine(square);
            }

            Console.WriteLine(string.Format("squares== copy? {0}", squares == copy));
        }

        public void ArraySort()
        {
            var days = DaysOfTheWeek();
            var comparer = new StringLengthComparer();
            Array.Sort(days, comparer);
            foreach (var day in days)
            {
                Console.WriteLine(day);
            }
        }


    }
}
