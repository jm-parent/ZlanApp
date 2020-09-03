using System.ComponentModel;
using Xamarin.Forms;
using ZlanMobileApp.ViewModels;

namespace ZlanMobileApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}