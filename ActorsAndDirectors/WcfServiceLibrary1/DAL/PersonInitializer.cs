using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WcfServiceLibrary1.DAL
{
    class PersonInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            //base.Seed(context);
        }
    }
}
