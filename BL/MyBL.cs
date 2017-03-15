using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Web.Syndication;

using BE;
using Newtonsoft.Json;
using System.IO;

namespace BL
{
    public class MyBL
    {
        public static Uri Link { get { return link; } set { link = value; } }
        private static Uri link;
        [IgnoreDataMember]
        public string LinkAsString
        {
            get { return Link?.OriginalString ?? String.Empty; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) return;

                if (!value.Trim().StartsWith("http://") && !value.Trim().StartsWith("https://"))
                {
                }
                else
                {
                    Uri uri = null;
                    if (Uri.TryCreate(value.Trim(), UriKind.Absolute, out uri)) Link = uri;
                    else
                    {
                    }
                }
            }
        }

        public MyBL()
        {
            DAL.MyDAL dal = new DAL.MyDAL(); 
        }

        public async Task<List<Article>> GetFeed()
        {
            var feed = await new SyndicationClient().RetrieveFeedAsync(Link);
            List<Article> articles = feed.Items.Select(item => new Article
            {
                Title = item.Title.Text.ToString(),
                Summary = item.Summary == null ? string.Empty :
             item.Summary.Text.RegexRemove("\\&.{0,4}\\;").RegexRemove("<.*?>"),
                Author = item.Authors.Select(a => a.NodeValue).FirstOrDefault(),
                Link = item.ItemUri ?? item.Links.Select(l => l.Uri).FirstOrDefault(),
                PublishedDate = item.PublishedDate.DateTime,
                ArticleNumber = null
            }).ToList<Article>();
            //var feedswriter = File.OpenWrite("feeds.json");
            foreach (var item in articles)
            {
                //var message = JsonConvert.SerializeObject(item);
                //byte[] bmessage = Encoding.ASCII.GetBytes(message);
                //feedswriter.Write(bmessage, (int)feedswriter.Position, bmessage.Length);
                DAL.MyDAL.SaveArticle(item);
                //var md = new MessageDialog(item.ToString());
                //await md.ShowAsync();
            }
            return articles;
        }

        public static async Task<string> Search(string searchstring)
        {
            string result= await DAL.MyDAL.GetArticle(searchstring);
            return result;
        }

        
}
}
