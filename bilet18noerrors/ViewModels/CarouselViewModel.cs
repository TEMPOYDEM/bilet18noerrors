using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace bilet18noerrors.ViewModels
{
    class CarouselViewModel
    {
        public CarouselViewModel()
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
            await Shell.Current.GoToAsync("//LoginPage");
        }
        public ICommand ButtonClick { get; }
        public ICommand OpenWebCommand { get; }
    }
}
