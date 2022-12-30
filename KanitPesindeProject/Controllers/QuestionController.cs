using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.Controllers
{
    public class QuestionController : Controller
    {
        QuestionOneManager qom = new QuestionOneManager(new EfQuestionOneDal());
        QuestionTwoManager qtm = new QuestionTwoManager(new EfQuestionTwoDal());
        public IActionResult Index()
        {
            return View();
        }
    }
}
