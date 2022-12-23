using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.ViewComponents.Intro
{
    public class IntroList:ViewComponent
    {
        IntroManager introManager = new IntroManager(new EfIntroDal());
        public IViewComponentResult Invoke() //Invoke view componente gitmeyi sağlayan metottur. Shared içinde Default.cshtml açılır
        {
            var values = introManager.TGetList();
            return View(values);
        }
    }
}
