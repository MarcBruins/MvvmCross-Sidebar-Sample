using System;
using MvvmCross.Core.ViewModels;
using sidebar.Core.ViewModels;

namespace sidebar.Core
{
	public class OtherViewModel : MvxViewModel
	{
		public OtherViewModel()
		{
		}

		public void ShowMenu()
		{
			ShowViewModel<MenuViewModel>();
		}
	}
}

