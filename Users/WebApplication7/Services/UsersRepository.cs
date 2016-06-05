using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication7.Context;
using WebApplication7.Models;

namespace WebApplication7.Services
{
    public class UsersRepository : IUsersRepository
    {
        private UserContext db = new UserContext();

        public int Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();

            return user.UserId;
        }

        public bool Delete(int id)
        {
            User u = db.Users.Find(id);

            if (u == null)
            {
                return false;
            }

            db.Users.Remove(u);
            db.SaveChanges();

            return true;
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public User Update(User user)
        {
            User u = db.Users.Find(user.UserId);

            if (u == null)
            {
                return null;
            }

            u = user;
            db.SaveChanges();

            return u;
        }
    }
}