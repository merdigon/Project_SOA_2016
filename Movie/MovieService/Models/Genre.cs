﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoviesService.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        
    }
}