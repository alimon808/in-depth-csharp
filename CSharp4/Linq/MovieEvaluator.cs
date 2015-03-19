using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp4.Linq
{
    public class MovieEvaluator
    {
        public bool IsValid(Movie movie)
        {
            Func<Movie, bool>[] rules = 
            {
                m => string.IsNullOrEmpty(m.Title),
                m => m.Length < 60 || m.Length > 400,
                m => m.ReleaseDate.Year < 1903
            };

            return rules.All(rule => rule(movie) == false);
        }
    }
}
