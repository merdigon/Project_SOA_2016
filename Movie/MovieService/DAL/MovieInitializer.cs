using MoviesService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesService.DAL
{
    public class MovieInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            var genres = new List<Genre>
            {
                new Genre() {Name = "Horror"},
                new Genre() {Name = "Adventure"},
                new Genre() {Name = "Thriller"},
                new Genre() {Name = "Comedy"},
                new Genre() {Name = "Animated"},

            };
            genres.ForEach(i => context.Genres.Add(i));
            context.SaveChanges();

            var movies = new List<Movie>
            {
                new Movie() {Title = "Pewny Film", Description = "SOA movie", Year = 2016, DirectorID = 1, Country = "Poland", Genre = context.Genres.Single(x=>x.Name == "Horror") },
                new Movie() {Title = "Pewny Film 2", Description = "Cool movie", Year = 2015, DirectorID = 1, Country = "Poland", Genre = context.Genres.Single(x=>x.Name == "Comedy") },
                new Movie() {Title = "Third Movie", Description = "Nice thriller", Year = 2010, DirectorID = 2, Country = "England", Genre = context.Genres.Single(x=>x.Name == "Thriller") },

            };
            movies.ForEach(i => context.Movies.Add(i));
            context.SaveChanges();

        }
    }
}