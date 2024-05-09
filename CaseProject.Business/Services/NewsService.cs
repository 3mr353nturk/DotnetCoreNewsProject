using CaseProject.Core.Models;
using CaseProject.DataAccess.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.Business.Services
{
    //NewsService, Haber verileriyle ilgili işlemler gerçekleştirir. Haberleri filtreleme ve listeleme gibi işlemleri yapar.
    public class NewsService
    {
        private readonly NewsRepository _newsRepository;

        public NewsService(NewsRepository newsDataAccess)
        {
            _newsRepository = newsDataAccess;
        }

        public async Task<List<NewsItem>> GetAllNews()
        {
            var allNews = await _newsRepository.GetNewsAsync();
            return allNews;
        }

        public async Task<List<NewsItem>> GetFilteredNews(string category, string keyword)
        {
            var allNews = await _newsRepository.GetNewsAsync();

            if (!string.IsNullOrEmpty(category))
            {
                allNews = allNews.Where(n => n.Category.Title.ToLower() == category.ToLower()).ToList();
            }

            if (!string.IsNullOrEmpty(keyword))
            {
                allNews = allNews.Where(n => n.Title.ToLower().Contains(keyword.ToLower())).ToList();
            }

            return allNews;
        }

        public async Task<NewsDetail> GetNewsDetailAsync()
        {
            var detail = await _newsRepository.GetNewsDetailAsync();
            return detail;
        }
    }
}
