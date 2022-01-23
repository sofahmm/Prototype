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
    public partial class ProjectPage : ContentPage
    {
        public string[] Projects { get; set; } 
        public ProjectPage()
        {
            InitializeComponent();
            Projects = new string[] {"Проект 1", "Проект 2", "Проект 3", "Проект 4", 
                                    "Проект 5", "Проект 6", "Проект 7", "Проект 8", 
                                    "Проект 9", "Проект 10", "Проект 11", "Проект 12", 
                                    "Проект 13", "Проект 14", "Проект 15", "Проект 16", 
                                    "Проект 17", "Проект 18", "Проект 19", };
            this.BindingContext = this;
        }
    }
}