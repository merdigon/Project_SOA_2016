using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models
{
    public class Movie : ResourceBase
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Year { get; set; }

        public Director Director { get; set; }

        [Browsable(false)]
        public int DirectorID { get; set; }
        
        public string Country { get; set; }
        
        public Genre Genre { get; set; }

        [Browsable(false)]
        public List<int> ActorsID { get; set; }

        public List<Actor> Actors { get; set; }

        [Browsable(false)]
        public string CoverURI { get; set; }
    }
}
