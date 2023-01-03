using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.ViewComponents.QuestionOne
{
    public class QuestionOneList:ViewComponent
    {
        QuestionOneManager qom = new QuestionOneManager(new EfQuestionOneDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = qom.TGetList(id);  //parantez içine values yazmayı unutma 
            return View(values);  
        }

    }
}
