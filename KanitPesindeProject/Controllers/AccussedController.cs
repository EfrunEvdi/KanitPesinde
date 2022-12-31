
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.Controllers
{
    public class AccussedController : Controller
    {
        AccussedOneManager aom = new AccussedOneManager(new EfAccussedOneDal());
        AccussedTwoManager atm = new AccussedTwoManager(new EfAccussedTwoDal());
        public IActionResult AccussedOne()
        {
            var values = aom.GetAccussedOneListWithInvOne();
            return View(values);
        }
        public IActionResult AccussedTwo()
        {
            return View();
        }
    }
}
