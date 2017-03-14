using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using BE;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TryToDoRSS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RSSview : Page
    {
        List<Article> articles;
        BL.MyBL bl;
        public RSSview()
        {
            this.InitializeComponent();
            bl = new BL.MyBL();
            LinkBox.Text = "http://www.inn.co.il/Rss.aspx";
        }

        private async void FeedsButton_Click(object sender, RoutedEventArgs e)
        {
            bl.LinkAsString = LinkBox.Text;
            articles = await bl.GetFeed();
            FeedsListBox.DataContext = articles;
        }
    }
}
