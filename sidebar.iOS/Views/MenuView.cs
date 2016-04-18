using System;

using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Support.SidePanels;
using Foundation;
using sidebar.Core.ViewModels;
using CoreGraphics;

namespace sidebar.iOS
{
	[MvxPanelPresentation(MvxPanelEnum.Left, MvxPanelHintType.ActivePanel, false)]
	public partial class MenuView : MvxViewController<MenuViewModel>
	{
		private CGColor borderColor = new CGColor(45, 177, 128);
		private UIColor TextColor = UIColor.White,BackgroundColor = UIColor.FromRGB(14,76,116);

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		
			View.BackgroundColor = BackgroundColor;

			MenuTableView.BackgroundColor = UIColor.Clear;
			//Corner radius and color
			ProfileImage.Layer.CornerRadius = (ProfileImage.Frame.Width / 2);
			ProfileImage.Layer.BorderWidth = 1.5f;
			ProfileImage.Layer.BorderColor = borderColor;
			ProfileImage.Layer.MasksToBounds = true;

			//Label colors
			BigLabel.TextColor = TextColor;
			SmallLabel.TextColor = TextColor;

			MenuTableView.Source = new MenuTableViewSource(ViewModel.MenuItems);
			MenuTableView.AllowsSelection = false; //no selection and no styling
			MenuTableView.SeparatorColor =  UIColor.FromRGBA (187, 187, 187,0.1f);

			MenuTableView.TableFooterView = new UIView(CGRect.Empty) { BackgroundColor = BackgroundColor };


			//MenuTableView.TableFooterView.Hidden = false;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


