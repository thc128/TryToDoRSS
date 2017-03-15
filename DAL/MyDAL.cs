using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Newtonsoft.Json;
using BE;
using Firebase.Database;
using Firebase.Database.Query;
using Windows.UI.Popups;
using System.Reactive.Linq;

namespace DAL
{
    public class MyDAL
    {
        string Auth { set; get; }
        static FirebaseClient firebaseClient;
        public MyDAL()
        {
            Auth = "xsRoTOrWBkB4UmilRvPTPXbj55AcV9AF2mgHlsgJ";
            firebaseClient = new FirebaseClient(
             "https://ourproject128.firebaseio.com/",
            new FirebaseOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(Auth)
            });
        }
        public static async void SaveArticle(Article article)
        {
            //var auth = "xsRoTOrWBkB4UmilRvPTPXbj55AcV9AF2mgHlsgJ";
            //var firebaseClient = new FirebaseClient(
            // "https://ourproject128.firebaseio.com/",
            //new FirebaseOptions
            //{
            //    AuthTokenAsyncFactory = () => Task.FromResult(auth)
            //});
            try
            {
                await firebaseClient.Child("my feeds").Child("article " + article.GetHashCode().ToString()).PutAsync(article);
            }
            catch (Exception e)
            {
                var md = new MessageDialog(e.Message);
                await md.ShowAsync();
            }
        }

        public static async Task<string> GetArticle(string searchstring)
        {
            var child = firebaseClient.Child("myfeeds");           
            var m = await child.OrderBy("Title").StartAt(searchstring).OnceAsync<Article>();
            return m.ToString();
        }
    }
}
