using CaseProject.Business.Services;
using CaseProject.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaseProject.Controllers
{
    //HTTP isteklerini alır, ilgili metodları çağırır ve dönen sonuçları View'lere iletir.
    public class NewsController : Controller
    {
        private readonly NewsService _newsService;

        public NewsController(NewsService newsService)
        {
            _newsService = newsService;
        }
        //Anasayfa için haber listesini görüntüler. Filtreleme ve sayfalama işlemlerini yapar.
        public async Task<IActionResult> Index(string category = null, string keyword = null, int pageNumber = 1, int pageSize = 5)
        {
            List<NewsItem> news;

            if (!string.IsNullOrEmpty(category) || !string.IsNullOrEmpty(keyword))
            {
                var filteredNews = await _newsService.GetFilteredNews(category, keyword);
                news = filteredNews.ToList();
            }
            else
            {
                var allNews = await _newsService.GetAllNews();
                news = allNews.ToList();
            }

            // Toplam haber sayısı
            int totalItems = news.Count;

            // Toplam sayfa sayısı
            int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

            // Sayfalama işlemi
            var paginatedNews = news.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.PageNumber = pageNumber;
            ViewBag.TotalPages = totalPages;
            ViewBag.Category = category;
            ViewBag.Keyword = keyword;

            return View(paginatedNews);
        }
        //Haber detay sayfasını görüntüler. Haber detaylarını alır ve sayfayı açar.
        public async Task<IActionResult> Details()
        {
            var detail = await _newsService.GetNewsDetailAsync();
            return View(detail);
        }
    }
}
