﻿using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDetailComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleDetailComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke(int id)
        {
            id = 1;
            var value=_articleService.TGetById(id);
            return View(value);
        }
    }
}
