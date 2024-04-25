using Microsoft.AspNetCore.Mvc;
using MyBlog.BusinessLayer.Abstract;

namespace MyBlog.PresentationLayer.Controllers
{
    public class BlogController : Controller
    {
        private readonly IArticleService _articleService;
        public BlogController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IActionResult BlogDetail(int id)
        {
            id = 2;
            var values = _articleService.TGetById(id);
            ViewBag.createdDate = values.CreatedDate;
            ViewBag.title=values.Title;

            ViewBag.detail = values.Detail;

            var values2 = _articleService.TGetArticleWithCategoryByArticleId(id);
            ViewBag.categoryName = values2.Category.CategoryName;

           

            return View();
        }
    }
}
