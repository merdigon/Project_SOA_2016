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
        }
    }
}
