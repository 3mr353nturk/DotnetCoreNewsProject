using CaseProject.Core.Models;
using CaseProject.DataAccess.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.DataAccess.Repositories
{
    //NewsRepository, HttpClient ile ilgili json dosyalarından haber verilerini almak için kullanılır.
    public class NewsRepository : INewsRepository
    {
        private readonly HttpClient _httpClient;

        public NewsRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<NewsItem>> GetNewsAsync()
        {
            var response = await _httpClient.GetAsync("https://www.turkmedya.com.tr/anasayfa.json");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(content);
                var itemList = json["data"][1]["itemList"];
                var newsItems = itemList.ToObject<List<NewsItem>>();
                return newsItems;
            }
            else
            {
                throw new Exception("Veriler alınamadı.");
            }
        }

        public async Task<NewsDetail> GetNewsDetailAsync()
        {
            var response = await _httpClient.GetAsync("https://www.turkmedya.com.tr/detay.json");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(content);
                var itemList = json["data"]["newsDetail"];
                var newsDetail = itemList.ToObject<NewsDetail>();
                return newsDetail;
            }
            else
            {
                throw new Exception("Veriler alınamadı.");
            }
        }
    }
}
