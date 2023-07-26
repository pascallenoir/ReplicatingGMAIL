using ReplicatingGMAIL.Models;
using ReplicatingGMAIL.ViewModels;
using ReplicatingGMAIL.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReplicatingGMAIL.Views
{
    public partial class BoiteDeReception : ContentPage
    {
        BoiteDeReceptionEmailListeViewModel _viewModel;

        public BoiteDeReception()
        {
            InitializeComponent();

            BindingContext = _viewModel = new BoiteDeReceptionEmailListeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}