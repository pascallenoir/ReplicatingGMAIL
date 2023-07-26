using ReplicatingGMAIL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReplicatingGMAIL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageDeRecherche : ContentPage
    {
        //JoinTablesViewModelListe _viewModel;

        public PageDeRecherche()
        {
            InitializeComponent();
            //BindingContext = _viewModel = new JoinTablesViewModelListe();
        }

      
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //_viewModel.OnAppearing();
            DependencyService.Get<IStatusBar>().ShowStatusBar();
        }
    }
}