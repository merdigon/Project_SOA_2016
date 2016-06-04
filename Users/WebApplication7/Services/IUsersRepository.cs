using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication7.Models;

namespace WebApplication7.Services
{
    interface IUsersRepository
    {
        List<User> GetAll();
        User Get(int id);
        int Add(User user);
        User Update(User user);
        bool Delete(int id);
    }
}
