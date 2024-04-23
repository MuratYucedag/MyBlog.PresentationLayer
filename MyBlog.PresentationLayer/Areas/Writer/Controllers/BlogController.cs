using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.BusinessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.PresentationLayer.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;
        public BlogController(UserManager<AppUser> userManager, IArticleService articleService)
        {
            _userManager = userManager;
            _articleService = articleService;
        }
        public async Task<IActionResult> MyBlogList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _articleService.TGetArticlesWithCategoryByWriter(user.Id);
            return View(values);
        }

        public IActionResult DeleteBlog(int id)
        {
            _articleService.TDelete(id);
            return RedirectToAction("MyBlogList");
        }

        [HttpGet]
        public IActionResult UpdateBlog(int id)
        {
            var values = _articleService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateBlog(Article article)
        {
            _articleService.TUpdate(article);
            return RedirectToAction("MyBlogList");
        }

        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(Article article)
        {
            _articleService.TInsert(article);
            return RedirectToAction("MyBlogList");
        }

    }
}