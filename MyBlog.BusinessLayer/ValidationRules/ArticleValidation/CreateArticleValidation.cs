using FluentValidation;
using MyBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BusinessLayer.ValidationRules.ArticleValidation
{
    public class CreateArticleValidation : AbstractValidator<Article>
    {
        public CreateArticleValidation()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyiniz").MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız").MaximumLength(100).WithMessage("Lütfen en fazla 100 karakter veri girişi yapınız");
            RuleFor(x => x.Detail).NotEmpty().WithMessage("Lütfen boş geçmeyin");
        }
    }
}
