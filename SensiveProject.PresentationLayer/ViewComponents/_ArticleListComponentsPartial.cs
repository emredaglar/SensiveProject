using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.DataAccessLayer.Abstract;

namespace SensiveProject.PresentationLayer.ViewComponents
{
    public class _ArticleListComponentsPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleListComponentsPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }
    }
}
