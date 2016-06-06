using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActorsAndDirectors.DAL;
using ActorsAndDirectors.Models;

namespace ActorsAndDirectors
{
    class PeopleService : IPeopleService
    {
        private PersonContext db = new PersonContext();
        public ActorRepository repo = new ActorRepository();

        public void DeleteActor(Actor a)
        {
            repo.Delete(a.Id);
        }

        public void DeleteDirector(Director d)
        {
            db.Directors.Attach(d);
            db.Directors.Remove(d);
            db.SaveChanges();
        }

        public List<Actor> GetActors()
        {
            return repo.ReadAll();
        }

        public List<Actor> GetActorsByName(string s)
        {
            return repo.GetActorsWithName(s);
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
            var r = repo.Read(a.Id);

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

                repo.Update(r);
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
                return repo.Create(a);   
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


        public Director GetDirector(int id)
        {
            return db.Directors.Where(x => x.PersonId == id).FirstOrDefault();
        }

        public Actor GetActor(int id)
        {
            return repo.Read(id);
        }
    }
}
