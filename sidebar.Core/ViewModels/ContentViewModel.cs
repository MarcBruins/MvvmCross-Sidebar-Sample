using System;
using MvvmCross.Core.ViewModels;

namespace sidebar.Core.ViewModels
{
	public class ContentViewModel : MvxViewModel
	{
		public ContentViewModel ()
		{
		}

		public void ShowMenu()
		{
			ShowViewModel<MenuViewModel>();
		}
	}
}

