using Microsoft.AspNetCore.Mvc;

namespace MongoDb.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
