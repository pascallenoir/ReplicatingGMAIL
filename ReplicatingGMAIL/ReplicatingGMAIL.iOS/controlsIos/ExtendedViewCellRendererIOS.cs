using System;
using UIKit;
using ReplicatingGMAIL.Controls;
using ReplicatingGMAIL.iOS.controlsIos;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtendedViewCell), typeof(ExtendedViewCellRendererIOS))]
namespace ReplicatingGMAIL.iOS.controlsIos
{
    public class ExtendedViewCellRendererIOS : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            var view = item as ExtendedViewCell;
            cell.SelectedBackgroundView = new UIView
            {
                BackgroundColor = view.SelectedBackgroundColor.ToUIColor(),
            };

            return cell;
        }

    }
}