using Microsoft.AspNetCore.Mvc;
using MVCIntroDemo.Models;
using System.Diagnostics;

namespace MVCIntroDemo.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Page";
            ViewBag.Message = "This is an ASP.NET Core MVC app.";
            return View();
        }

        public IActionResult Numbers ()
        {
            ViewBag.Title = "Nums 1 ... 50";
            return View();
        }

        public IActionResult NumbersToN(int n = 3)
        {
            ViewBag.Count = n;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}