using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp4.Test.Linq
{
    [TestFixture]
    public class ProjectionOperatorTests
    {
        [Test]
        public void ShouldTestSelectManyOperator()
        {
            string[] famousQuotes = 
            { 
                "Advertising is legalized lying", 
                "Advertising is the greatest art form of the twentieth century" 
            };


            //var query = (from sentence in famousQuotes
            //             from word in sentence.Split(' ')
            //             select word).Distinct();

            var query = famousQuotes.SelectMany(s => s.Split(' ')).Distinct();


            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
    }
}
