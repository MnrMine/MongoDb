using Microsoft.AspNetCore.Mvc;

namespace MongoDb.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
