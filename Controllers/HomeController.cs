using JoelHiltonMovies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHiltonMovies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AddMovieContext MovieContext { get; set; }

        public HomeController(ILogger<HomeController> logger, AddMovieContext somename)
        {
            _logger = logger;
            MovieContext = somename;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(AddMovie am)
        {
            MovieContext.Add(am);
            MovieContext.SaveChanges();

            return View("Confirmation", am);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult MovieList()
        {
            return View();
        }
    }
}
