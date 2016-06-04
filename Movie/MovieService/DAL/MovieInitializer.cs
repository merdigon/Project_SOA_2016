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

        }
    }
}