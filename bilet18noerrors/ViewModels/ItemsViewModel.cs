using bilet18noerrors.Models;
using bilet18noerrors.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace bilet18noerrors.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ItemsViewModel()
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