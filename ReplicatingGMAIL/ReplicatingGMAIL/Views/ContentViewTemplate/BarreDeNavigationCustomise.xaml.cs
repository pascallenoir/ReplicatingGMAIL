using ReplicatingGMAIL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReplicatingGMAIL.Views.ContentViewTemplate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarreDeNavigationCustomise : ContentView
    {
        public BarreDeNavigationCustomise()
        {
            InitializeComponent();
            BindingContext = new BarreDeNavigationCustomiseViewModel();
        }
    }
}