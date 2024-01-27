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

        public IActionResult GetNumber(int number) {
            {
                ViewBag.Number = "GetNumber";

                return View("Number",number);
            } }
    }
}
