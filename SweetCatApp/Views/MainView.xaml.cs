using SweetCatApp.Models;
using System.Linq.Expressions;


namespace SweetCatApp
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

       
    }

}
