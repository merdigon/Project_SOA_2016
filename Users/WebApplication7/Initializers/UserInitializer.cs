using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Context;
using WebApplication7.Models;

namespace WebApplication7.Initializers
{
    public class UserInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
        }
    }
}