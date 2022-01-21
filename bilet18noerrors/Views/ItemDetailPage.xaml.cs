using bilet18noerrors.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace bilet18noerrors.Views
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