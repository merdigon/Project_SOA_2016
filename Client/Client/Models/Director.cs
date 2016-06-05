using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Director : ResourceBase
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Gender { get; set; }
        public string RealName { get; set; }
        public string MaritalStatus { get; set; }
        public int Height { get; set; }
        public string PlaceOfBirth { get; set; }
        public string DateOfBirth { get; set; }
        public bool Alive { get; set; }
        public List<Movie> Movies { get; set; }

        public override string ToString()
        {
            return Name + " " + RealName;
        }
    }
}
