using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UsersInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UsersContext>
    {
        protected override void Seed(UsersContext context)
        {
            var users = new List<User>()
            {
                new User()
                {
                    Nick = "abc",
                    Name = "Aaa Bbb",
                    Email = "aaa@bbb.com",
                    Password = "ccc",
                    City = "Cba",
                },
                new User()
                {
                    Nick = "def",
                    Name = "Ddd Eee",
                    Email = "ddd@eee.com",
                    Password = "fff",
                    City = "Fed",
                },
                new User()
                {
                    Nick = "ghi",
                    Name = "Ggg Hhh",
                    Email = "ggg@hhh.com",
                    Password = "iii",
                    City = "Ihg",
                }
            };

            users.ForEach(i => context.Users.Add(i));
            context.SaveChanges();
        }
    }
}
