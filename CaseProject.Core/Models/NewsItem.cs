using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.Core.Models
{
    //Haberi temsil eden sınıf
    public class NewsItem
    {
        public string ShortText { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
    }
}
