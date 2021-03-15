using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMDB.ViewModel;
using IMDB.Models;
using IMDB.Controllers;

namespace IMDB.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Movies
        public ActionResult Movies()
        {
            var customers = new List<Customers>
            {
                new Customers { Name = "test" },
                new Customers { Name = "test2" }
            };

            var MoviesCust = new RandomMovie()
            {
                Movies = new Movies { Name = "Batman" },
                customers = customers
            };

            return View(MoviesCust);
             
        }

        [Route("Movies/Customers")]
        public ActionResult Customers()
        {
            var customer = new List<Customers>
            {
                new Customers {Name = "Test"},
                new Customers {Name = "Test1"}
            };

            var viewModel = new RandomMovie
            {
                customers = customer
            };

            return View(viewModel);
        }
    }
}