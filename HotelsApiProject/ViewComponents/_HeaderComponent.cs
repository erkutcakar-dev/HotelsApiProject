
using Microsoft.AspNetCore.Mvc;

namespace HotelsApiProject.ViewComponents
{
    public class _HeaderComponent : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
