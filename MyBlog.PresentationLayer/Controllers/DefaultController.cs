using Microsoft.AspNetCore.Mvc;

namespace MyBlog.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
