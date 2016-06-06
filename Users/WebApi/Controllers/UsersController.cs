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
    public class UsersController : ODataController
    {
        UsersContext db = new UsersContext();

        [EnableQuery]
        public IQueryable<User> Get()
        {
            return db.Users;
        }
        [EnableQuery]
        public SingleResult<User> Get([FromODataUri] int key)
        {
            IQueryable<User> result = db.Users.Where(p => p.UserId == key);
            return SingleResult.Create(result);
        }

        public async Task<IHttpActionResult> Post(User review)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Users.Add(review);
            await db.SaveChangesAsync();
            return Created(review);
        }

        public async Task<IHttpActionResult> Put([FromODataUri] int key, User update)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (key != update.UserId)
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
                if (!UserExists(key))
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
            var product = await db.Users.FindAsync(key);
            if (product == null)
            {
                return NotFound();
            }
            db.Users.Remove(product);
            await db.SaveChangesAsync();
            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool UserExists(int key)
        {
            return db.Users.Any(p => p.UserId == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
