using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class User : ResourceBase
    {
        public string Login { get; set; }

        public override string ToString()
        {
            return Login;
        }
    }
}
