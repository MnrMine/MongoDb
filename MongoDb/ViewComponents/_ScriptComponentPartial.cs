using Microsoft.AspNetCore.Mvc;

namespace MongoDb.ViewComponents
{
    public class _ScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
