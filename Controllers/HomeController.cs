using JoelHiltonMovies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = MovieContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(AddMovie am)
        {
            ViewBag.Categories = MovieContext.Categories.ToList();
            if (ModelState.IsValid)
            {
            MovieContext.Add(am);
            MovieContext.SaveChanges();

            return View("Confirmation", am);
            }
            else
            {
                return View(am);
            }
            
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult MovieList()
        {
            var movie = MovieContext.Movies
            .Include(x => x.Category)
            .OrderBy(x => x.CategoryId)
            .ToList();
            return View(movie);
        }
        [HttpGet]
        public IActionResult Edit (int MovieId)
        {
            ViewBag.Categories = MovieContext.Categories.ToList();
            var category = MovieContext.Movies.Single(x => x.MovieId == MovieId);
            return View("MovieForm", category);
        }
        [HttpPost]
        public IActionResult Edit (AddMovie am)
        {
            MovieContext.Update(am);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int MovieId)
        {
            var m = MovieContext.Movies.Single(x => x.MovieId == MovieId);
            return View(m);
        }
        [HttpPost]
        public IActionResult Delete(AddMovie am)
        {
            MovieContext.Movies.Remove(am);
            MovieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
