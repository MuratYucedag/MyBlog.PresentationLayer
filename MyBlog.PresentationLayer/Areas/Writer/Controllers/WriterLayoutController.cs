using Microsoft.AspNetCore.Mvc;

namespace MyBlog.PresentationLayer.Areas.Writer.Controllers
{

    [Area("Writer")]
    public class WriterLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
