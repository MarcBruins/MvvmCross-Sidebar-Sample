using System;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;

namespace sidebar.Core.ViewModels
{
	public class MenuViewModel : MvxViewModel
	{
		public List<MenuModel> MenuItems {
			get;
		}

		public MenuViewModel ()
		{
			MenuItems = new List<MenuModel> ();
			MenuItems.Add(new MenuModel(){Title = "Home", ImageName="ic_build_white", Navigate = NavigateHome});
			MenuItems.Add(new MenuModel(){Title = "About", ImageName="ic_description_white", Navigate = NavigateHome});
			MenuItems.Add(new MenuModel(){Title = "MvvmCross", ImageName="ic_settings_white", Navigate = NavigateHome});
			MenuItems.Add(new MenuModel(){Title = "Xamarin", ImageName="ic_explore_white", Navigate = NavigateHome});
			MenuItems.Add(new MenuModel(){Title = "Microsoft", ImageName="ic_credit_card_white", Navigate = NavigateHome});
			MenuItems.Add(new MenuModel(){Title = "Evolve", ImageName="ic_device_hub_white", Navigate = NavigateHome});
		}
			
		private MvxCommand _resetCommand;
		public MvxCommand NavigateHome
		{
			get 
			{
				_resetCommand = _resetCommand ?? new MvxCommand(() => ShowViewModel<CenterViewModel>());
				return _resetCommand;
			}
		}


	}
}

