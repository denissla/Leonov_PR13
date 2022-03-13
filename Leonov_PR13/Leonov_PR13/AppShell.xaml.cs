using Leonov_PR13.ViewModels;
using Leonov_PR13.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Leonov_PR13
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
