using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeVidProject.Models;
using HomeVidProject.ViewModels;

namespace HomeVidProject.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


       
        [Route("movies/random")]
        public ViewResult Random()
        {
            var movies = _context.Movies.Include(m => m.Genre);
            

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movies = movies
            //};
            

            return View(movies);
        }


        [Route("movies/details/{id}")]
        public ViewResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            return View(movie);

        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year = "+ year + " month =" + month);
        }


        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie {Name = "Equalizer 1"},
        //        new Movie {Name = "The Day The Earth Stood Still"}
        //    };
        //}
    }
}