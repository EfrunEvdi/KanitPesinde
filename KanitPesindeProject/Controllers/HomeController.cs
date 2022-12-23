using KanitPesindeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KanitPesindeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
		public IActionResult Introdeneme()
		{
			return View();
		}

        public IActionResult Newspaper1deneme()
        {
            return View();
        }
        public IActionResult Newspaper2deneme()
        {
            return View();
        }

        public IActionResult Lastdeneme()
        {
            return View();
        }
        public IActionResult Detectivestorydeneme()
        {
            return View();
        }
        public IActionResult Investigation1deneme()
        {
            return View();
        }
        public IActionResult Investigation2deneme()
        {
            return View();
        }
        public IActionResult Accused1deneme()
        {
            return View();
        }
        public IActionResult Accused2deneme()
        {
            return View();
        }
        public IActionResult Crimescene1deneme()
        {
            return View();
        }
        public IActionResult Crimescene2deneme()
        {
            return View();
        }
        public IActionResult Hint1deneme()
        {
            return View();
        }
        public IActionResult Hint2deneme()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
