using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mike03.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mike03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Return the Index page
        public IActionResult Index()
        {
            return View();
        }

        //Return the Podcasts page
        public IActionResult MyPodcasts()
        {
            return View();
        }

        //Return the Enter a New Movie page
        [HttpGet]
        public IActionResult EnterNewMovie()
        {
            return View();
        }
        //Post the form inputs, create an object out of them, send the confirmation page to user
        [HttpPost]
        public IActionResult EnterNewMovie(EnterNewMovieResponse oNewMovie)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddMovie(oNewMovie);
                return View("Confirmation", oNewMovie);
            }
            return View();
        }

        //Return the Movie Database page
        public IActionResult MovieDatabase()
        {
            return View(TempStorage.Movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
