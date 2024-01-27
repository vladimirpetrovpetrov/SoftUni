using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro2024.Controllers
{
    public class IntroController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Intro";
            return View();
        }

        public IActionResult GetNumber(int number)
        {
            {
                ViewBag.Number = "GetNumber";

                return View("Number", number);
            }
        }

        public IActionResult Article()
        {
            ViewBag.Title = "The Little Prince";
            ViewBag.Content = "The Little Prince, fable and modern classic by French aviator and writer Antoine de Saint-Exupéry that was published with his own illustrations in French as Le Petit Prince in 1943. The simple tale tells the story of a child, the little prince, who travels the universe gaining wisdom. The novella has been translated into hundreds of languages and has sold some 200 million copies worldwide, making it one of the best-selling books in publishing history.";
            ViewBag.Author = "Saint-Exupéry";
            return View();
        }
    }
}
