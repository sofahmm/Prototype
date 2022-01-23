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
            this.Content = lbl_description;
        }
        Label lbl_description = new Label
        {
            Text = "Spoken words were meant to last, \n" +

                                                    "but the picture faded fast \n" +
                                                    "The words I love you meant so much,\n" +
                                                    "now not even your lips can I touch \n" +
                                                    "I'll cry for another eyesore and think about our first kiss by the tree \n" +
                                                    "And how it meant so much to me \n" +
                                                    "Nobody knows the me that you do \n" +
                                                    "Gonna take some getting used to \n" +
                                                    "And I think I'm getting through to you \n" +
                                                    "But I got shit I put you through \n" +
                                                    "It ain't right and I know that I'm barely ever home \n" +
                                                    "But I think of you on the road \n" +
                                                    "You know I think of you on blow \n" +
                                                    "It's me, Lil Jeep, she don't keep not a memory of me \n" +
                                                    "I'ma creep, I'ma freak,\n",  
            FontSize= 18
        };
    }
}