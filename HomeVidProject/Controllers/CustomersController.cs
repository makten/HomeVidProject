using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeVidProject.Models;
using HomeVidProject.ViewModels;


namespace HomeVidProject.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }


        [Route("customers/random")]
        public ActionResult Index()
        {
           
            //var customers = _context.Customers.ToList();
            var customers = _context.Customers.Include(c => c.MembershipType);

           
            return View(customers);
        }

        [Route("customers/details/{Id}")]
        public ActionResult Details(int Id)
        {

            //var customer = customers.Find(c => c.Id == Id);

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer {Id = 1, Name = "John Doe (JD)"},
        //        new Customer {Id = 2, Name = "Kofi Kololo (KK)"}
        //    };
        //}

        
    }
}