
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.Controllers
{
    public class AccusedController : Controller
    {
        AccussedOneManager aom = new AccussedOneManager(new EfAccussedOneDal());
        AccussedTwoManager atm = new AccussedTwoManager(new EfAccussedTwoDal());
        public IActionResult AccusedOne()
        { 
            return View();
        }
        public IActionResult AccusedTwo()
        {
            return View();
        }
    }
}
