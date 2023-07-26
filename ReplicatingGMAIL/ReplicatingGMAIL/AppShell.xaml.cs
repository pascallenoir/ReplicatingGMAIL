using ReplicatingGMAIL.ViewModels;
using ReplicatingGMAIL.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ReplicatingGMAIL
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(BoiteDeReception), typeof(BoiteDeReception));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage)); 
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage)); 
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));
            Routing.RegisterRoute(nameof(MessageNonLusPage), typeof(MessageNonLusPage));

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
