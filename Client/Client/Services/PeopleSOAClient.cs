using soaP = Client.PeopleService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using view = Client.Models;
using Client.ProcessObjects;

namespace Client.Services
{
    public class PeopleSOAClient
    {
        private soaP.PeopleServiceClient Client { get; set; }
        public ProcessObject ProcessObject { get; set; }

        public PeopleSOAClient(ProcessObject processObject)
        {
            Client = new soaP.PeopleServiceClient();
            ProcessObject = processObject;
        }

        public List<view.Actor> GetActorsByName(string namePart)
        {
            var list = (Client.GetActorsByName(namePart) ?? new soaP.Actor[0]);
            return list.Select(p => ProcessObject.Mapper.Map<view.Actor>(p)).ToList();
        }

        public List<view.Director> GetDirectorsByName(string namePart)
        {
            var list = (Client.GetDirectorsByName(namePart) ?? new soaP.Director[0]);
            return list.Select(p => ProcessObject.Mapper.Map<view.Director>(p)).ToList();
        }

        public view.Director GetDirector(int directorId)
        {
            var dire = (Client.GetDirector(directorId) ?? new soaP.Director());
            return ProcessObject.Mapper.Map<view.Director>(dire);
        }

        public view.Actor GetActor(int actorId)
        {
            var actor = (Client.GetActor(actorId) ?? new soaP.Actor());
            return ProcessObject.Mapper.Map<view.Actor>(actor);
        }

        public void DeleteActor(int id)
        {
            Client.DeleteActor(new soaP.Actor() { PersonId = id });
        }

        public bool UpdateActor(view.Actor actor)
        {
            soaP.Actor actorToUpdate = ProcessObject.Mapper.Map<soaP.Actor>(actor);
            return Client.UpdateActor(actorToUpdate);
        }

        public view.Actor AddActor(view.Actor actor)
        {
            soaP.Actor actorToAdd = ProcessObject.Mapper.Map<soaP.Actor>(actor);
            return ProcessObject.Mapper.Map<view.Actor>(Client.AddActor(actorToAdd));
        }

        public void DeleteDirector(int id)
        {
            Client.DeleteDirector(new soaP.Director() { PersonId = id });
        }

        public bool UpdateDirector(view.Director director)
        {
            soaP.Director directorToUpdate = ProcessObject.Mapper.Map<soaP.Director>(director);
            return Client.UpdateDirector(directorToUpdate);
        }
        
        public view.Director AddDirector(view.Director director)
        {
            soaP.Director directorToAdd = ProcessObject.Mapper.Map<soaP.Director>(director);
            return ProcessObject.Mapper.Map<view.Director>(Client.AddDirector(directorToAdd));
        }
    }
}
