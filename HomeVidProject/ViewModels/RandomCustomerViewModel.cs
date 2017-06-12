using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HomeVidProject.Models;

namespace HomeVidProject.ViewModels
{
    public class RandomCustomerViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Movie> Movies { get; set; }
    }
}