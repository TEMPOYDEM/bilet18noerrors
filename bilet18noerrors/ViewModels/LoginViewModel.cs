using bilet18noerrors.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace bilet18noerrors.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        public class WebPage : Xamarin.Forms.ContentPage
        {
            public WebPage()
            {
                var browser = new WebView();
                browser.Source = "https://dotnet.microsoft.com/apps/xamarin";
                Content = browser;
            }
        }
        public LoginViewModel()
        {

            OpenWebCommand = new Command(BlueButton);
            ButtonClick = new Command(OnButton);
            
        }
        async void BlueButton()
        {
            await Shell.Current.GoToAsync("//CarouselPage");
        }
        async void OnButton()
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
        public ICommand ButtonClick { get; }
        public ICommand OpenWebCommand { get; }
    }
}
