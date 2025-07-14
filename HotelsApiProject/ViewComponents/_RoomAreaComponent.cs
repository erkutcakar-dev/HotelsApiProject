
using Microsoft.AspNetCore.Mvc;

namespace HotelsApiProject.ViewComponents
{
    public class _RoomAreaComponent :ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
