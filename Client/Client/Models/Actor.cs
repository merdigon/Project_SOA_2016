using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Actor : ResourceBase
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string Gender { get; set; }


        [DisplayName("Surname")]
        public string RealName { get; set; }

        [DisplayName("Marital Status")]
        public string MaritalStatus { get; set; }
        public int Height { get; set; }

        [DisplayName("Place Of birth")]
        public string PlaceOfBirth { get; set; }

        [DisplayName("Date of birth")]
        public string DateOfBirth { get; set; }
        public bool Alive { get; set; }
        [Browsable(false)]
        public List<Movie> Movies { get; set; }

        public override string ToString()
        {
            return Name + " " + RealName;
        }
    }
}
