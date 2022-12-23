using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke() //Invoke view componente gitmeyi sağlayan metottur. Shared içinde Default.cshtml açılır
        {
            var values = aboutManager.TGetList();
            return View(values);
        }
    }
}
