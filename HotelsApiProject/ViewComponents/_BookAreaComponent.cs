using Microsoft.AspNetCore.Mvc;

namespace HotelsApiProject.ViewComponents
{
    public class _BookAreaComponent:ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
