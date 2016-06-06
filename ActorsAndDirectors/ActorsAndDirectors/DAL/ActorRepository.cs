using ActorsAndDirectors.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActorsAndDirectors.DAL
{
    public class ActorRepository
    {
        private readonly string _conn;

        private readonly string _collectionName;

        public ActorRepository()
        {
            _collectionName = "actor";
            _conn = @"C:\tmp\actor";
        }

        protected string Conn
        {
            get
            {
                return _conn;
            }
        }

        protected string CollectionName
        {
            get
            {
                return _collectionName;
            }
        }

        //CRUD PART

        public List<Actor> GetActorsWithName(string name)
        {
            using (var db = new LiteDatabase(_conn))
            {
                var repository = db.GetCollection<Actor>(CollectionName);
                if (string.IsNullOrEmpty(name))
                    return ReadAll();
                return repository.Find(p => p.Name.Contains(name)).ToList();
            }
        }

        public Actor Create(Actor model)
        {
            using (var db = new LiteDatabase(_conn))
            {
                var repository = db.GetCollection<Actor>(_collectionName);
                if (repository.FindById(model.Id) != null)
                    repository.Update(model);
                else
                {
                    int nextId;
                    if(repository.FindAll().Count() == 0)
                        nextId = 1;
                    else
                        nextId = repository.FindAll().ToList().Select(p => p.Id).Max() + 1;
                    model.Id = nextId;
                    repository.Insert(model);
                }
                return model;
            }
        }

        public Actor Read(int id)
        {
            using (var db = new LiteDatabase(_conn))
            {
                var repository = db.GetCollection<Actor>(_collectionName);
                var result = repository.FindById(id);
                return result;
            }
        }

        public List<Actor> ReadAll()
        {
            using (var db = new LiteDatabase(_conn))
            {
                List<Actor> objects = new List<Actor>();
                var repository = db.GetCollection<Actor>(_collectionName);
                foreach (var result in repository.FindAll())
                {
                    objects.Add(result);
                }
                return objects;
            }
        }

        public List<Actor> Read(int[] ids)
        {
            using (var db = new LiteDatabase(_conn))
            {
                List<Actor> objects = new List<Actor>();
                var repository = db.GetCollection<Actor>(_collectionName);
                foreach (int id in ids)
                {
                    var result = repository.FindById(id);
                    objects.Add(result);
                }
                return objects;
            }
        }

        public bool Update(Actor model)
        {
            using (var db = new LiteDatabase(_conn))
            {
                var repository = db.GetCollection<Actor>(_collectionName);
                if (repository.Update(model))
                    return true;
                else
                    return false;
            }
        }

        public bool Delete(int id)
        {
            using (var db = new LiteDatabase(_conn))
            {
                var repository = db.GetCollection<Actor>(_collectionName);
                return repository.Delete(id);
            }
        }
    }
}
