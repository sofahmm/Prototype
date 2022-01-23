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
            StackLayout sl_pictures = new StackLayout();
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
            ScrollView sv_pict = new ScrollView();
  
            sl_pictures.Children.Add(img_pictures1);
            sl_pictures.Children.Add(img_pictures2);
            sl_pictures.Children.Add(img_pictures3);
            

            sl_pictures.Children.Add(sl_pictures);
            sl_pictures.Children.Add(sl_pictures);
            sl_pictures.Children.Add(sl_pictures);
            sv_pict.Content = sl_pictures;

            this.Content = sv_pict;
   
        }
    }
}