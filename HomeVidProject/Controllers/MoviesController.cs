using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeVidProject.Models;
using HomeVidProject.ViewModels;

namespace HomeVidProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies --ViewResult or ActionResult
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "The Book Of Eli!"};
            var customers = new List<Customer>
            {
                new Customer() {Name = "John Doe" },
                new Customer() { Name = "Kofi Kololo" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };



            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);

        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year = "+ year + " month =" + month);
        }
    }
}