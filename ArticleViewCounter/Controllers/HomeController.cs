using ArticleViewCounter.DTOs.ViewModels;
using ArticleViewCounter.EntityFrameworkCore.Repositories;
using ArticleViewCounter.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArticleViewCounter.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;
        public HomeController(IMapper mapper, IArticleRepository articleRepository)
        {
            _mapper = mapper;
            _articleRepository = articleRepository;
        }

        public async Task<IActionResult> Index()
        {
            var itemsDb = await _articleRepository.GetAllAsync();

            var items = _mapper.Map<List<ArticleVM>>(itemsDb);

            return View(items);
        }

        public async Task<IActionResult> ArticleDetail(int articleId)
        {
            var itemDb = await _articleRepository.GetByIdAsync(articleId);

            if (itemDb == null)
                return RedirectToAction("Index");

            int NewNumberOfViews = await _articleRepository.IncreaseNumberOfWiewByOne(articleId);

            var item = _mapper.Map<ArticleDetailVM>(itemDb);
            item.NumberOfViews = NewNumberOfViews;

            return View(item);
        }
    }
}