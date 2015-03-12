using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Configuration;
using System.Data.Linq.Mapping;

namespace CSharp3.LINQ
{
    public class LinqToSql
    {
        public IEnumerable<Movie> GetMovies()
        {
            var connectionString = @"Data Source=localhost;Initial Catalog=Sandbox; Integrated Security=True";
            //DataContext ctx = new DataContext(
            //    connectionString,
            //    XmlMappingSource.FromUrl("../../MovieMapping.xml"));
            DataContext ctx = new DataContext(connectionString);

            Console.WriteLine(ctx.Log);

            var movies = from m in ctx.GetTable<Movie>()
                         select m;
            Console.WriteLine(ctx.Log);

            return movies.ToList();
        }
    }
}
