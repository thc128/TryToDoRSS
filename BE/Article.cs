using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Article
    {
        public string ArticleNumber { set; get; }
        public string Title { set; get; }
        public string Summary { set; get; }
        public string Author { set; get; }
        public Uri Link { set; get; }
        public DateTime PublishedDate { set; get; }

        public override string ToString()
        {
            return Title + "\n\n" + Summary + "\n\n author:" + Author + "\n\n link:" + Link.ToString() + "\n\n Date:" + PublishedDate.ToString(); 
        }
    }
}
