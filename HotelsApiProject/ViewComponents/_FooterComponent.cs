using Microsoft.AspNetCore.Mvc;

namespace HotelsApiProject.ViewComponents
{
    public class _FooterComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
