using Microsoft.AspNetCore.Mvc;

namespace Core_KanitPesindeProject.ViewComponents.DetectiveStory
{
    public class DetectiveStoryList : ViewComponent
    {
        public IViewComponentResult Invoke() //Invoke view componente gitmeyi sağlayan metottur. Shared içinde Default.cshtml açılır
        {
            return View();
        }
    }
}
