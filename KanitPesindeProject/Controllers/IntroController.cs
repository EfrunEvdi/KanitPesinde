using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.Controllers
{
    public class IntroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Intro()
        {
            return PartialView();
        }
        public PartialViewResult AboutTheGame()
        {
            return PartialView();
        }
    }
}
