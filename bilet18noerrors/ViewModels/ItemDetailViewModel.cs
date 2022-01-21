using bilet18noerrors.Models;
using System;
using bilet18noerrors.Views;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bilet18noerrors.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Command CancelCommand { get; }
        public ItemDetailViewModel()
        {
            CancelCommand = new Command(OnCancel);
        }
        public class WebPage : ContentPage
        {
            public WebPage()
            {
                var browser = new WebView();
                browser.Source = "https://dotnet.microsoft.com/apps/xamarin";
                Content = browser;
            }
        }
        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("//AboutPage");
        }

    }
}
