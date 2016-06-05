using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1.DAL;
using WcfServiceLibrary1.Models;

namespace WcfServiceLibrary1
{
    class PeopleService : IPeopleService
    {
        private PersonContext db = new PersonContext();

        public void DeleteActor(Actor a)
        {
            db.Actors.Remove(a);
            db.SaveChanges();
        }

        public void DeleteDirector(Director d)
        {
            db.Directors.Remove(d);
            db.SaveChanges();
        }

        public List<Actor> GetActors()
        {
            return db.Actors.ToList();
        }

        public List<Actor> GetActorsByName(string s)
        {
            return db.Actors.Where(x => x.Name.Contains(s)).ToList();
        }

        public List<Director> GetDirectors()
        {
            return db.Directors.ToList();
        }

        public List<Director> GetDirectorsByName(string s)
        {
            return db.Directors.Where(x => x.Name.Contains(s)).ToList();
        }

        public bool UpdateActor(Actor a)
        {
            var r = db.Actors.SingleOrDefault(x => x.PersonId == a.PersonId);

            if(r != null)
            {
                r.Name = a.Name;
                r.Gender = a.Gender;
                r.RealName = a.RealName;
                r.MaritalStatus = a.MaritalStatus;
                r.Height = a.Height;
                r.PlaceOfBirth = a.PlaceOfBirth;
                r.DateOfBirth = a.DateOfBirth;
                r.Alive = a.Alive;

                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateDirector(Director a)
        {
            var r = db.Directors.SingleOrDefault(x => x.PersonId == a.PersonId);

            if (r != null)
            {
                r.Name = a.Name;
                r.Gender = a.Gender;
                r.RealName = a.RealName;
                r.MaritalStatus = a.MaritalStatus;
                r.Height = a.Height;
                r.PlaceOfBirth = a.PlaceOfBirth;
                r.DateOfBirth = a.DateOfBirth;
                r.Alive = a.Alive;

                db.SaveChanges();
                return true;
            }
            return false;
        }

        Actor IPeopleService.AddActor(Actor a)
        {
            try
            {
                db.Actors.Add(a);
                db.SaveChanges();

                return a;
            }
            catch (Exception)
            {
                return null;
            }
        }

        Director IPeopleService.AddDirector(Director d)
        {
            try
            {
                db.Directors.Add(d);
                db.SaveChanges();

                return d;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
