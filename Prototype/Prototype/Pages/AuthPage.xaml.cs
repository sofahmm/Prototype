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
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            InitializeComponent();
            /*StackLayout sl_auth = new StackLayout();
            Image img_auth = new Image();
            img_auth.Source = new UriImageSource
            {
                CachingEnabled = false,
                Uri = new System.Uri("https://funart.pro/uploads/posts/2021-04/1617398181_57-p-oboi-les-estetika-58.jpg"),
                
            };
            Label lbl_login = new Label() { 
                Text = "Логин",
                FontSize = 17
            };
            Entry entry_login = new Entry()
            {
                FontSize = 24,
                Placeholder = "Email"
            };
            Label lbl_password = new Label()
            {
                Text = "Пароль",
                FontSize = 17
            };
            Entry entry_password = new Entry()
            {
                FontSize = 24,
                Placeholder = "Password",
                IsPassword = true
            };
            Button btn_login = new Button()
            {
                Text = "Войти",
                FontSize = 28,
            };
            btn_login.Clicked += btn_login_click;

            Button btn_registration = new Button()
            {
                Text = "Зарегистрироваться",
                FontSize = 28
            };
            btn_registration.Clicked += btn_reg_click;

            //img_auth.Source = ImageSource.FromResource("Prototype.img.nirvana.jpg");
            sl_auth.Children.Add(img_auth);
            sl_auth.Children.Add(lbl_login);
            sl_auth.Children.Add(entry_login);
            sl_auth.Children.Add(lbl_password);
            sl_auth.Children.Add(entry_password);
            sl_auth.Children.Add(btn_login);
            sl_auth.Children.Add(btn_registration);
            this.Content = sl_auth;*/
        }

        private async void btn_registr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectPage());
        }
    }
}