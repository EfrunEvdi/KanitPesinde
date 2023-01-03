using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.Controllers
{
    public class InvestigationController : Controller
    {
        InvestigationOneManager iom = new InvestigationOneManager(new EfInvestigationOneDal());
        InvestigationTwoManager itm = new InvestigationTwoManager(new EfInvestigationTwoDal());
        public IActionResult InvestigationOne(int id)
        {
            ViewBag.i = id;
            var values = iom.GetInvestigationOneByID(id);
            return View(values);
        }
        public IActionResult InvestigationTwo()
        {
            return View();
        }
    }
}
