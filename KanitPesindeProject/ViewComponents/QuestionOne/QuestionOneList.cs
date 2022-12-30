using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.ViewComponents.QuestionOne
{
    public class QuestionOneList:ViewComponent
    {
       // QuestionOneManager qom = new QuestionOneManager(new EfQuestionOneDal());
        public IViewComponentResult Invoke()
        {
            //var values = qom.TGetList(1);  parantez içine values yazmayı unutma 
            return View();  
        }

    }
}
