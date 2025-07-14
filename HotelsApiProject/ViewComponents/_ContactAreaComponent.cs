using Microsoft.AspNetCore.Mvc;

namespace HotelsApiProject.ViewComponents
{
    public class _ContactAreaComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
    
}
