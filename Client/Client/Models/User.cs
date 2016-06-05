using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class User : ResourceBase
    {
        public string Nick { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Browsable(false)]
        public string Password { get; set; }
        public string City { get; set; }
        
        public override string ToString()
        {
            return Nick;
        }
    }
}
