using System;
using MvvmCross.Core.ViewModels;

namespace sidebar.Core.ViewModels
{
	public class CenterViewModel : MvxViewModel
	{
		public CenterViewModel ()
		{
		}

		public void ShowMenu()
		{
			// Loads the flyout menu on the left
			ShowViewModel<MenuViewModel>();
		}
	}
}

