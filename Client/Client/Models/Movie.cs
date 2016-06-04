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
        [DisplayName("Tytuł")]
        public string Title { get; set; }

        [DisplayName("Opis")]
        public string Description { get; set; }

        [DisplayName("Rok produkcji")]
        public int Year { get; set; }

        [DisplayName("Reżyser")]
        public Director Director { get; set; }
        
        [DisplayName("Kraj")]
        public string Country { get; set; }
        
        [DisplayName("Kategoria")]
        public Genre Genre { get; set; }

        [DisplayName("Aktorzy")]
        public List<Actor> Actors { get; set; }

        [DisplayName("Obrazek")]
        public string CoverURI { get; set; }
    }
}
