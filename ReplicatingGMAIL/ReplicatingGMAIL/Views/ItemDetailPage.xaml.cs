using ReplicatingGMAIL.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ReplicatingGMAIL.Views
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