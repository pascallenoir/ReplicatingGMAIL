using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using ReplicatingGMAIL.Controls;
using ReplicatingGMAIL.Droid.controlsAndroid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SearchBarRendererControl), typeof(SearchBarRendererANDROID))]
namespace ReplicatingGMAIL.Droid.controlsAndroid
{
    public class SearchBarRendererANDROID : SearchBarRenderer
    {
        public SearchBarRendererANDROID(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = null;
            }
        }
    }
}