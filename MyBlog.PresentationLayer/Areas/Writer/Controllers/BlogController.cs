using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBlog.BusinessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;

namespace MyBlog.PresentationLayer.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        public BlogController(UserManager<AppUser> userManager, IArticleService articleService, ICategoryService categoryService)
        {
            _userManager = userManager;
            _articleService = articleService;
            _categoryService = categoryService;
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
            List<SelectListItem> values = (from x in _categoryService.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(Article article)
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            article.CreatedDate = DateTime.Now;
            article.AppUserId=user.Id;

            _articleService.TInsert(article);
            return RedirectToAction("MyBlogList");
        }

    }
}
/*
  List<SelectListItem> values = new List<SelectListItem>();

    // İlk olarak "kategori seçiniz" ifadesini ekleyin
    values.Add(new SelectListItem
    {
        Text = "Kategori Seçiniz",
        Value = "", // Buraya boş bir değer verin veya istediğiniz bir değeri atayın
        Selected = true // Varsayılan olarak seçili olsun
    });

    // Ardından kategori listesini ekleyin
    values.AddRange(from x in _categoryService.TGetListAll()
                    select new SelectListItem
                    {
                        Text = x.CategoryName,
                        Value = x.CategoryId.ToString()
                    });

    ViewBag.v = values;
 */