using System;

using UIKit;
using MvvmCross.iOS.Views;
using sidebar.Core.ViewModels;
using MvvmCross.iOS.Support.SidePanels;
using Foundation;

namespace sidebar.iOS
{
	[MvxPanelPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
	public partial class CenterView : MvxViewController<CenterViewModel>
	{

		public CenterView () 
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.


			ViewModel.ShowMenu ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


