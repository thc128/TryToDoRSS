using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Newtonsoft.Json;
using BE;
using Firebase.Database;
using Firebase.Database.Query;

namespace DAL
{
    public class MyDAL
    {
        //string Auth { set; get; }
        //static FirebaseClient firebaseClient;
        public static int _ArticleNumber = 100;
        public MyDAL()
        {
            //Auth = "xsRoTOrWBkB4UmilRvPTPXbj55AcV9AF2mgHlsgJ";
            //firebaseClient = new FirebaseClient(
            // "https://ourproject128.firebaseio.com/",
            //new FirebaseOptions
            //{
            //    AuthTokenAsyncFactory = () => Task.FromResult(Auth)
            //});
        }
        public static async void SaveArticle(Article article)
        {
            var auth = "xsRoTOrWBkB4UmilRvPTPXbj55AcV9AF2mgHlsgJ";
            var firebaseClient = new FirebaseClient(
             "https://ourproject128.firebaseio.com/",
            new FirebaseOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(auth)
            });
            // _ArticleNumber = await firebaseClient.Child("articlenumber").OnceSingleAsync<int>();3
            article.ArticleNumber = _ArticleNumber.ToString();
            _ArticleNumber++;
           // await firebaseClient.Child("articlenumber").PutAsync(_ArticleNumber.ToString());

            await firebaseClient.Child("my feeds").Child("article " + article.ArticleNumber).Child(article.Title).Child("summary").PutAsync(article.Summary);
            await firebaseClient.Child("my feeds").Child("article " + article.ArticleNumber).Child(article.Title).Child("link").PutAsync(article.Link);
            await firebaseClient.Child("my feeds").Child("article " + article.ArticleNumber).Child(article.Title).Child("date").PutAsync(article.PublishedDate);
            await firebaseClient.Child("my feeds").Child("article " + article.ArticleNumber).Child(article.Title).Child("author").PutAsync(article.Author);

        }
        //public static async List<Article> GetArticle()
        //{
        //}
    }
}
