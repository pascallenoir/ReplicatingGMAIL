using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicatingGMAIL.Droid.controlsAndroid;
using ReplicatingGMAIL.Interface;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(StatusBarImplementation))]
namespace ReplicatingGMAIL.Droid.controlsAndroid
{
    public class StatusBarImplementation : IStatusBar
    {
        public StatusBarImplementation()
        {
        }

        WindowManagerFlags _originalFlags;

        #region IStatusBar implementation

        [Obsolete]
        public void HideStatusBar()
        {
            var activity = (Activity)Forms.Context;
            var attrs = activity.Window.Attributes;
            _originalFlags = attrs.Flags;
            attrs.Flags |= Android.Views.WindowManagerFlags.Fullscreen;
            activity.Window.Attributes = attrs;
        }

        public void ShowStatusBar()
        {
            var activity = (Activity)Forms.Context;
            var attrs = activity.Window.Attributes;
            attrs.Flags = _originalFlags;
            activity.Window.Attributes = attrs;
        }

        #endregion
    }
}
