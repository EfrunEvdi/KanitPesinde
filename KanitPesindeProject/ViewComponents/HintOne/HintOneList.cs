using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.ViewComponents.HintOne
{
    public class HintOneList : ViewComponent
    {
        public IViewComponentResult Invoke() //Invoke view componente gitmeyi sağlayan metottur. Shared içinde Default.cshtml açılır
        {
            return View();
        }
    }
}
