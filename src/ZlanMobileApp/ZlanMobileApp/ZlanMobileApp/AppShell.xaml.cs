using System;
using System.Collections.Generic;
using ZlanMobileApp.ViewModels;
using ZlanMobileApp.Views;
using Xamarin.Forms;

namespace ZlanMobileApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
