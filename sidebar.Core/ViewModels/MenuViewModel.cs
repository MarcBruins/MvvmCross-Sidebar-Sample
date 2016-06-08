using System;
using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace sidebar.Core.ViewModels
{
	public class MenuViewModel : MvxViewModel
	{
		public List<MenuModel> MenuItems
		{
			get;
		}

		public MenuViewModel()
		{
			MenuItems = new List<MenuModel>();
			MenuItems.Add(new MenuModel() { Title = "Home", ImageName = "ic_build_white", Navigate = NavigateHome });
			MenuItems.Add(new MenuModel() { Title = "About", ImageName = "ic_description_white", Navigate = NavigateOtherViewModel });
			MenuItems.Add(new MenuModel() { Title = "MvvmCross", ImageName = "ic_settings_white", Navigate = NavigateOtherViewModel });
			MenuItems.Add(new MenuModel() { Title = "Xamarin", ImageName = "ic_explore_white", Navigate = NavigateOtherViewModel });
			MenuItems.Add(new MenuModel() { Title = "Microsoft", ImageName = "ic_credit_card_white", Navigate = NavigateOtherViewModel });
			MenuItems.Add(new MenuModel() { Title = "Evolve", ImageName = "ic_device_hub_white", Navigate = NavigateOtherViewModel });

		}

		private MvxCommand _resetCommand;
		public MvxCommand NavigateHome
		{
			get
			{
				_resetCommand = _resetCommand ?? new MvxCommand(() => ShowViewModel<ContentViewModel>());
				return _resetCommand;
			}
		}

		private MvxCommand _navigateOtherViewModel;
		public MvxCommand NavigateOtherViewModel
		{
			get
			{
				_navigateOtherViewModel = _navigateOtherViewModel ?? new MvxCommand(() => ShowViewModel<OtherViewModel>());
				return _navigateOtherViewModel;
			}
		}
	}
}
