using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.Controllers
{
    public class IntroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
