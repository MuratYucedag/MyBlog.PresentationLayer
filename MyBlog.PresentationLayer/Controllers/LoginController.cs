using Microsoft.AspNetCore.Mvc;

namespace MyBlog.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
