using Microsoft.AspNetCore.Mvc;

namespace MongoDb.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
