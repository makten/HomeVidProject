using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeVidProject.Models;

namespace HomeVidProject.ViewModels
{
    public class RandomMovieModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}