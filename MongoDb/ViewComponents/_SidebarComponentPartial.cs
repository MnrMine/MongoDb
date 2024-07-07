using Microsoft.AspNetCore.Mvc;

namespace MongoDb.ViewComponents
{
    public class _SidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
