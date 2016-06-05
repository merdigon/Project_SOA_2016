using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ReviewsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ReviewsContext>
    {
        protected override void Seed(ReviewsContext context)
        {
            var reviews = new List<Review>
            {
                new Review() {Content = "Nice", Note = 5, MovieID = 1, UserID = 1, Date = new DateTime(2010, 11, 11, 20, 22, 22)},
                new Review() {Content = "Bad", Note = 3, MovieID = 1, UserID = 2, Date = new DateTime(2010, 10, 10, 20, 22, 22)},

                new Review() {Content = "Nice", Note = 5, MovieID = 2, UserID = 1, Date = new DateTime(2010, 10, 9, 20, 22, 22)},
                new Review() {Content = "Bad", Note = 1, MovieID = 2, UserID = 2, Date = new DateTime(2010, 9, 10, 20, 22, 22)},

                new Review() {Content = "Nice", Note = 4, MovieID = 3, UserID = 1, Date = new DateTime(2010, 8, 10, 20, 22, 22)},
                new Review() {Content = "Bad", Note = 2, MovieID = 3, UserID = 2, Date = new DateTime(2010, 7, 10, 20, 22, 22)},

            };
            reviews.ForEach(i => context.Reviews.Add(i));
            context.SaveChanges();
        }
    }
}
