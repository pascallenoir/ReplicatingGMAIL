using System;
using CoreGraphics;
using UIKit;
using ReplicatingGMAIL.Controls;
using ReplicatingGMAIL.iOS.controlsIos;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryRendererPickerProfil), typeof(EntryRendererPickerProfilIOS))]
namespace ReplicatingGMAIL.iOS.controlsIos
{
    public class EntryRendererPickerProfilIOS : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            if (e.OldElement == null)
            {
                Control.Layer.BorderWidth = 0;
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}
