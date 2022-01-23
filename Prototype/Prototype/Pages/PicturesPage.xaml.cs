using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PicturesPage : ContentPage
    {
        public PicturesPage()
        {
            InitializeComponent();
            StackLayout sl_pictures1 = new StackLayout();
            StackLayout sl_pictures2 = new StackLayout();
            StackLayout sl_pictures3 = new StackLayout();
            Image img_pictures1 = new Image();
            Image img_pictures2 = new Image();
            Image img_pictures3 = new Image();
            Image img_pictures4 = new Image();
            Image img_pictures5 = new Image();
            Image img_pictures6 = new Image();
            img_pictures1.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://proprikol.ru/wp-content/uploads/2021/01/kartinki-stich-6.jpg"),
                

            };
            img_pictures2.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://proprikol.ru/wp-content/uploads/2021/01/kartinki-stich-6.jpg"),

            };
            img_pictures3.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://proprikol.ru/wp-content/uploads/2021/01/kartinki-stich-6.jpg"),

            };
            img_pictures4.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://proprikol.ru/wp-content/uploads/2021/01/kartinki-stich-6.jpg"),

            };
            img_pictures5.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://proprikol.ru/wp-content/uploads/2021/01/kartinki-stich-6.jpg"),

            };
            img_pictures6.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://proprikol.ru/wp-content/uploads/2021/01/kartinki-stich-6.jpg"),

            };
            ScrollView sv_pict1 = new ScrollView();
            sl_pictures1.Orientation = StackOrientation.Horizontal;
            sl_pictures2.Orientation = StackOrientation.Horizontal;
            sl_pictures3.Orientation = StackOrientation.Horizontal;
            sl_pictures1.Children.Add(img_pictures1);
            sl_pictures1.Children.Add(img_pictures2);
            sl_pictures2.Children.Add(img_pictures3);
            sl_pictures2.Children.Add(img_pictures4);
            sl_pictures3.Children.Add(img_pictures5);
            sl_pictures3.Children.Add(img_pictures6);

            this.Content = sv_pict1;
   
        }
    }
}