using System;
using MvvmCross.Core.ViewModels;

namespace sidebar.Core
{
	public class MenuModel
	{
		public String Title {
			get;
			set;
		}

		public String ImageName {
			get;
			set;
		}

		public IMvxCommand Navigate {
			get;
			set;
		}

		public MenuModel (){}
	}
}

