using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.PresentationLayer.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var userInfo = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.id = userInfo.Id;
            ViewBag.name = userInfo.Name;
            ViewBag.surname = userInfo.Surname;

            return View();
        }
    }
}
