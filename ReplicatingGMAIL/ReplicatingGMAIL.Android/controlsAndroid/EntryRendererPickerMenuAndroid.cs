﻿using System;
using Android.Content;
using ReplicatingGMAIL.Controls;
using ReplicatingGMAIL.Droid.controlsAndroid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(EntryRendererPickerMenu), typeof(EntryRendererPickerMenuAndroid))]
namespace ReplicatingGMAIL.Droid.controlsAndroid
{
   
    public class EntryRendererPickerMenuAndroid : PickerRenderer
        {

        public EntryRendererPickerMenuAndroid(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
            {
                base.OnElementChanged(e);

                if (e.OldElement == null)
                {
                    Control.SetBackgroundResource(Resource.Layout.rounded_shape);
                    //var gradientDrawable = new GradientDrawable();
                    //gradientDrawable.SetCornerRadius(60f);
                    //gradientDrawable.SetStroke(5, Android.Graphics.Color.DeepPink);
                    //gradientDrawable.SetColor(Android.Graphics.Color.LightGray);
                    //Control.SetBackground(gradientDrawable);
                    //
                    //Control.SetPadding(50, Control.PaddingTop, Control.PaddingRight,
                    //    Control.PaddingBottom);
                }
            }
        }

    }