using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

namespace CSharp3.LINQ.Tests
{
    [TestFixture]
    public class LinqToSqlTests
    {
        [Test]
        public void ShouldGetMovies()
        {
            var sut = new LinqToSql();
            var movies = sut.GetMovies();
            foreach (var movie in movies)
            {
                Console.WriteLine("{0}: {1}", movie.ReleaseDate.Year, movie.Title);
            }
        }
    }
}
