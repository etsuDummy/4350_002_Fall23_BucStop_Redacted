﻿using BucStop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

/*
 * This file has the controllers for everything outside of the games
 * and game-related pages.
 */

namespace BucStop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Sends the user to the deprecated Index page.
        public IActionResult Index()
        {
            return View();
        }

        //Takes the user to the admin page.
        public IActionResult Admin()
        {
            return View();
        }
        
        //Takes the user to the privacy policy page.
        public IActionResult Privacy()
        {
            return View();
        }

        //If something goes wrong, this will take the user to a page explaining the error.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}