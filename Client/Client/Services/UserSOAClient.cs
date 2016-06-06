using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.UserServices.Default;
using soaU = Client.UserServices.Library;
using view = Client.Models;
using Client.ProcessObjects;

namespace Client.Services
{
    public class UserSOAClient
    {
        private readonly Container container;

        public ProcessObject ProcessObject { get; set; }

        public UserSOAClient(ProcessObject processObject)
        {
            string serviceUri = "http://localhost:49848/";
            container = new Container(new Uri(serviceUri));
            ProcessObject = processObject;
        }

        public view.User AddUser(view.User review)
        {
            container.AddToUsers(ProcessObject.Mapper.Map<soaU.User>(review));
            var operationStatus = container.SaveChanges();
            
            return review;
        }

        public view.User GetUser(int id)
        {
            return ProcessObject.Mapper.Map <view.User>(container.Users.Where(p => p.UserId == id).FirstOrDefault());
        }

        public view.User CheckUserNameAndPassword(string username, string password)
        {
            var users = container.Users.Where(p => p.Nick.Equals(username)).ToList();
            var user = users.Where(p => p.Password.Equals(password)).FirstOrDefault();

            if (user == null)
                return null;

            return ProcessObject.Mapper.Map<view.User>(user);
        }
    }
}
