using System.ComponentModel;
using Xamarin.Forms;
using DataBindingPrepare.ViewModels;

namespace DataBindingPrepare.Views
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
