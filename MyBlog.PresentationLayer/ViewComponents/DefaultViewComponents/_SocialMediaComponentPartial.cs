using Microsoft.AspNetCore.Mvc;
using MyBlog.BusinessLayer.Abstract;

namespace MyBlog.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _SocialMediaComponentPartial:ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;
        public _SocialMediaComponentPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.TGetListAll();
            return View(values);
        }
    }
}
