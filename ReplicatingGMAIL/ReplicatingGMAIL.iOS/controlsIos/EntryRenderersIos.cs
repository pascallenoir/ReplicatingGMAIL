using System;
using CoreGraphics;
using UIKit;
using ReplicatingGMAIL.Controls;
using ReplicatingGMAIL.iOS.controlsIos;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryRenderers), typeof(EntryRenderersIos))]
namespace ReplicatingGMAIL.iOS.controlsIos
{
    public class EntryRenderersIos : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Layer.BorderWidth = 0;
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}
