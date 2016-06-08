using System;
using MvvmCross.iOS.Support.SidePanels;
using MvvmCross.iOS.Views;
using sidebar.Core;
using UIKit;

namespace sidebar.iOS
{
	[MvxPanelPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
	public partial class OtherView : MvxViewController<OtherViewModel>
	{
		public OtherView() : base("OtherView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			this.View.BackgroundColor = UIColor.Green;


			ViewModel.ShowMenu();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


