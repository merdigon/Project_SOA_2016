using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary1.Models;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    interface IPeopleService
    {
        [OperationContract]
        List<Actor> GetActors();

        [OperationContract]
        List<Director> GetDirectors();

        [OperationContract]
        Actor AddActor(Actor a);

        [OperationContract]
        Director AddDirector(Director d);

        [OperationContract]
        void DeleteActor(Actor a);

        [OperationContract]
        void DeleteDirector(Director d);

        [OperationContract]
        bool UpdateActor(Actor a);

        [OperationContract]
        bool UpdateDirector(Director d);

        [OperationContract]
        List<Actor> GetActorsByName(string s);

        [OperationContract]
        List<Director> GetDirectorsByName(string s);
    }
}
