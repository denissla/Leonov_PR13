using Leonov_PR13.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Leonov_PR13.Views
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