using Library;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Routing;

namespace ProductService.Controllers
{
    public class ReviewsController : ODataController
    {
        ReviewsContext db = new ReviewsContext();

        [EnableQuery]
        public IQueryable<Review> Get()
        {
            return db.Reviews;
        }
        [EnableQuery]
        public SingleResult<Review> Get([FromODataUri] int key)
        {
            IQueryable<Review> result = db.Reviews.Where(p => p.ReviewID == key);
            return SingleResult.Create(result);
        }

        [HttpGet]
        [ODataRoute("AverageNote(MovieID={movieID})")]
        public IHttpActionResult GetAverageNote([FromODataUri] int movieID)
        {
            int total = db.Reviews.Where(m => m.MovieID == movieID).Sum(s => s.Note);
            int count = db.Reviews.Where(p => p.MovieID == movieID).Count();
            if (count > 0)
            {
                double rate = total / (double)count;
                return Ok(rate);
            }
            else
            {
                return Ok(0);
            }
        }

        public async Task<IHttpActionResult> Post(Review review)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Reviews.Add(review);
            await db.SaveChangesAsync();
            return Created(review);
        }

        public async Task<IHttpActionResult> Put([FromODataUri] int key, Review update)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (key != update.ReviewID)
            {
                return BadRequest();
            }
            db.Entry(update).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Updated(update);
        }

        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            var product = await db.Reviews.FindAsync(key);
            if (product == null)
            {
                return NotFound();
            }
            db.Reviews.Remove(product);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool ReviewExists(int key)
        {
            return db.Reviews.Any(p => p.ReviewID == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
