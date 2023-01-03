using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.ViewComponents.Last
{
    public class LastList : ViewComponent
    {
        public IViewComponentResult Invoke() //Invoke view componente gitmeyi sağlayan metottur. Shared içinde Default.cshtml açılır
        {
            return View();
        }
    }
}
