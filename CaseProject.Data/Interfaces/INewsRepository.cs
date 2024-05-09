using CaseProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.DataAccess.Interfaces
{
    public interface INewsRepository
    {
        Task<List<NewsItem>> GetNewsAsync();
        Task<NewsDetail> GetNewsDetailAsync();
    }
}
