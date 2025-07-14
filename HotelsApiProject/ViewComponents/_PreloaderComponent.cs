using Microsoft.AspNetCore.Mvc;

namespace HotelsApiProject.ViewComponents
{
    public class _PreloaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
