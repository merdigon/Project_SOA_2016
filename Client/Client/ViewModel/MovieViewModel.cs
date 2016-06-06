using Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class MovieViewModel : ResourceBase
    {
        public MovieViewModel(Movie movie)
        {
            Source = movie;
        }

        public string Title { get { return (Source != null ? Source.Title : string.Empty); } set { } }

        public string Year { get { return (Source != null ? Source.Year.ToString() : string.Empty); } set { } }

        public string Country { get { return (Source != null ? Source.Country : string.Empty); } set { } }

        [Browsable(false)]
        public Movie Source { get; set; }
    }
}
