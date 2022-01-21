using bilet18noerrors.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace bilet18noerrors.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {

            OpenWebCommand = new Command(GreenButton);
            ButtonClick = new Command(OnButton);
        }
        async void OnButton()
        {
            await Shell.Current.GoToAsync("//ItemDetailPage");
        }
        async void GreenButton()
        {
            await Shell.Current.GoToAsync("//CarouselPage");
        }
        public ICommand ButtonClick { get; }
        public ICommand OpenWebCommand { get; }
    }
}
