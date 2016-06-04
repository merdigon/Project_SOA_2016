using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoviesService.Models
{
    public class Movie
    {

        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        //public virtual Director Director { get; set; }
        public virtual Genre Genre { get; set; }
        public string CoverURI { get; set; }
    }
}