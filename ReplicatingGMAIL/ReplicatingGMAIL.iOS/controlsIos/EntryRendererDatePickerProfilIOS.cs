using System;
using System.ComponentModel;
using CoreGraphics;
using UIKit;
using ReplicatingGMAIL.Controls;
using ReplicatingGMAIL.iOS.controlsIos;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryRendererDatePickerProfil), typeof(EntryRendererDatePickerProfilIOS))]
namespace ReplicatingGMAIL.iOS.controlsIos
{
    public class EntryRendererDatePickerProfilIOS : DatePickerRenderer
    {
        public new static void Init() { }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender,e);


           
        }
    }
}