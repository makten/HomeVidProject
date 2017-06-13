﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeVidProject.Models
{
    public class Movie
    {
        public int  Id { get; set; }

        [Required][StringLength(255)]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }
        [Required][Display(Name = "Genre")]
        public int GenreId { get; set; }


        [Required][Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Required][Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }
        
    }
}