using bilet18noerrors.ViewModels;
using bilet18noerrors.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace bilet18noerrors
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
