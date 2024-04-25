using Microsoft.AspNetCore.Mvc;

namespace MyBlog.PresentationLayer.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogDetail()
        {
            return View();
        }
    }
}
