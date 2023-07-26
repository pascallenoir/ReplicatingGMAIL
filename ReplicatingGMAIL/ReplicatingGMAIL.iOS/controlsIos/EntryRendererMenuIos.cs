﻿using System;
using CoreGraphics;
using ReplicatingGMAIL.iOS.controlsIos;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryRendererMenuIos))]
namespace ReplicatingGMAIL.iOS.controlsIos
{
    public class EntryRendererMenuIos : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
                return;
            Control.BorderStyle = UIKit.UITextBorderStyle.Line;
            Control.Layer.BorderWidth = 1;
            Control.Layer.BorderColor = Color.FromHex("#FFFFFF").ToCGColor();
            Control.Layer.BackgroundColor = Color.White.ToCGColor();

            Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
            Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
        }
    }
}
