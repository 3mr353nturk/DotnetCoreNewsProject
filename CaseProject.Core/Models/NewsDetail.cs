using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseProject.Core.Models
{
    //Haber detayını temsil eden sınıf
    public class NewsDetail
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string BodyText { get; set; }
        public string ShortText { get; set; }
    }
}
