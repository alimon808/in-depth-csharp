using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;


namespace CSharp3.LINQ
{
    public class LinqToEntityFramework
    {
        public void DisplayMovies()
        {
            var ctx = new CSharp3.LINQ.MovieReviews();
            var query = from m in ctx.Movies1
                        where m.ReleaseDate > new DateTime(2000, 1, 1)
                        select m;
            foreach (var m in query.Take(15))
            {
                Console.WriteLine(m.Title);
            }
        }

        public IEnumerable<Movie> GetMovies()
        {
            var ctx = new CSharp3.LINQ.MovieReviews();
            var query = from m in ctx.Movies1
                        where m.ReleaseDate > new DateTime(2000, 1, 1)
                        select m;

            return query;
        }

        // 
        public void MostReviewedMovi()
        {
            var ctx = new MovieReviews();
        }

        public int AddMovie()
        {
            using (var ctx = new MovieReviews())
            {
                Movie newMovie = new Movie
                {
                    Title = "The LINQ Love Story",
                    ReleaseDate = DateTime.Now
                };
                ctx.Movies1.Add(newMovie);
                ctx.SaveChanges();
                return newMovie.MovieId;
            }
        }

        public void UpdateMovie(int id)
        {
            using (var ctx = new MovieReviews())
            {
                var movie = ctx.Movies1.Where(m => m.MovieId == id).First();
                movie.ReleaseDate = DateTime.Now.AddYears(1);
                ctx.SaveChanges();
            }
        }

        public void DeleteMovie(int id)
        {
            using (var ctx = new MovieReviews())
            {
                var movie = ctx.Movies1.Where(m => m.MovieId == id).First();
                ctx.Movies1.Remove(movie);
                ctx.SaveChanges();
            }
        }

        // should return true
        public bool Isolation()
        {
            var ctx1 = new MovieReviews();
            var ctx2 = new MovieReviews();

            var m1 = ctx1.Movies1.Where(m => m.MovieId == 1).First();
            var m2 = ctx2.Movies1.Where(m => m.MovieId == 1).First();

            m2.ReleaseDate = DateTime.Now;
            ctx2.SaveChanges();

            // retrieve from Object Cache
            m1 = ctx1.Movies1.Where(m => m.MovieId == 1).First();
            return m1.ReleaseDate != m2.ReleaseDate;
        }

        public void RelatedEntities()
        {
            using (var ctx = new MovieReviews())
            {
                var m1 = ctx.Movies1.Include("Reviews").Where(m => m.Reviews.Count > 1).First();
                var m2 = ctx.Movies1.Include("Reviews").Where(m => m.MovieId != m1.MovieId).First();

                var reviews = m1.Reviews.ToList();
                foreach (var review in reviews)
                {
                    // m2.Reviews.Add(review);
                    review.Movie = m2;
                }

                ctx.SaveChanges();

            }
        }

        public void Concurrency()
        {
            var ctx1 = new MovieReviews();
            var ctx2 = new MovieReviews();

            var m1 = ctx1.Movies1.Where(m => m.MovieId == 1).First();
            var m2 = ctx2.Movies1.Where(m => m.MovieId == 1).First();

            try
            {
                m2.ReleaseDate = DateTime.Now;
                ctx2.SaveChanges();
                m1.ReleaseDate = DateTime.Now.AddYears(1);
                ctx1.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ctx1.Entry(m1).Reload();
                m1.ReleaseDate = DateTime.Now.AddYears(1);
                ctx1.SaveChanges();
            }
        }
    }
}
