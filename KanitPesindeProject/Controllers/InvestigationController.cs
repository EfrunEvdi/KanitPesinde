using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.Controllers
{
    public class InvestigationController : Controller
    {
        InvestigationOneManager iom = new InvestigationOneManager(new EfInvestigationOneDal());
        InvestigationTwoManager itm = new InvestigationTwoManager(new EfInvestigationTwoDal());
        public IActionResult InvestigationOne()
        {
            return View();
        }
        public IActionResult InvestigationTwo()
        {
            return View();
        }
    }
}
