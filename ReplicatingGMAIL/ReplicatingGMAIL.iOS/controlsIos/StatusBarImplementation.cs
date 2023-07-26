using Foundation;
using ReplicatingGMAIL.iOS.controlsIos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using ReplicatingGMAIL.Interface;
using ReplicatingGMAIL.iOS.controlsIos;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(StatusBarImplementation))]
namespace ReplicatingGMAIL.iOS.controlsIos
{
    public class StatusBarImplementation : IStatusBar
    {
        public StatusBarImplementation()
        {
        }

        #region IStatusBar implementation

        public void HideStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = true;
        }

        public void ShowStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = false;
        }

        #endregion
    }
}