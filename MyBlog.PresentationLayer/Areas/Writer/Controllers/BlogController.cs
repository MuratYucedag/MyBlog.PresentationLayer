using Microsoft.AspNetCore.Mvc;

namespace MyBlog.PresentationLayer.Areas.Writer.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult MyBlogList()
        {
            return View();
        }
    }
}
