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
    public partial class ProjectsInfoPage : ContentPage
    {
        public ProjectsInfoPage()
        {
            InitializeComponent();
            //this.Content = lbl_description;
            StackLayout sl_infoProj = new StackLayout();
            Label lbl_descrname = new Label()
            {
                Text = "Описание:",
                FontSize = 36,
                HorizontalTextAlignment = TextAlignment.Center
            };
            Label lbl_description = new Label
            {
               
            };
            Editor edt_description = new Editor()
            {
                Text = "Spoken words were meant to last, \n" +
                        " \n" +
                        "but the picture faded fast \n" +
                        " \n" +
                        "The words I love you meant so much,\n" +
                        " \n" +
                        "now not even your lips can I touch \n" +
                        " \n" +
                        "I'll cry for another eyesore and think about our first kiss by the tree \n" +
                        " \n" +
                        "And how it meant so much to me \n" +
                        " \n" +
                        "Nobody knows the me that you do \n" +
                        " \n" +
                        "Gonna take some getting used to \n" +
                        " \n" +
                        "And I think I'm getting through to you \n" +
                        " \n" +
                        "But I got shit I put you through \n" +
                        " \n" +
                        "It ain't right and I know that I'm barely ever home \n" +
                        " \n" +
                        "But I think of you on the road \n" +
                        " \n" +
                        "You know I think of you on blow \n" +
                        " \n" +
                        "It's me, Lil Jeep, she don't keep not a memory of me \n" +
                        " \n" +
                        "I'ma creep, I'ma freak,\n",
                FontSize = 18
            };
            ScrollView sv_descr = new ScrollView();
            sl_infoProj.Children.Add(lbl_descrname);
            sl_infoProj.Children.Add(edt_description);
            sv_descr.Content = sl_infoProj;
            this.Content = sv_descr;
        }
       
        
    }
}