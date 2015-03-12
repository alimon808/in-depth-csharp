using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CSharp3.LINQ.Tests
{
    [TestFixture]
    class LinqToEntityFrameworkTests
    {
        [Test]
        public void ShouldDisplayMovieTitles()
        {
            var sut = new LinqToEntityFramework();
            sut.DisplayMovies();
        }

        [Test]
        public void ShouldAddAndRemoveMovie()
        {
            var sut = new LinqToEntityFramework();
            var numberOfMovies = sut.GetMovies().ToList().Count;
            //Assert.That(numberOfMovies, Is.EqualTo(1));
            var id = sut.AddMovie();
            numberOfMovies++;
            Assert.That(sut.GetMovies().ToList().Count, Is.EqualTo(numberOfMovies));
            sut.DeleteMovie(id);
            numberOfMovies--;
            Assert.That(sut.GetMovies().ToList().Count, Is.EqualTo(numberOfMovies));

        }

        [Test]
        public void ShouldUpdateBraveheartReleaseDateOneYear()
        {
            var sut = new LinqToEntityFramework();
            sut.UpdateMovie(1);
            Assert.That(sut.GetMovies().First().ReleaseDate.Year, Is.EqualTo(2016));
        }

        [Test]
        public void ShouldReturnTrueForIsolation()
        {
            var sut = new LinqToEntityFramework();
            var result = sut.Isolation();
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldMoveReviewsToAnotherMovie()
        {
            var sut = new LinqToEntityFramework();
            sut.RelatedEntities();
        }

        [Test]
        public void ShouldTestConcurrency()
        {
            var sut = new LinqToEntityFramework();
            sut.Concurrency();
        }
    }
}
