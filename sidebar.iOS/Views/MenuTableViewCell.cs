using System;

using Foundation;
using UIKit;

namespace sidebar.iOS
{
	public partial class MenuTableViewCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("MenuTableViewCell");
		public static readonly UINib Nib;

		public UILabel MenuItemTextLabel {
			get { return LabelMenuItemName; }
			set { LabelMenuItemName = value; }
		}


		public UIImageView MenuImage{
			get { return MenuItemImage;}
			set { MenuItemImage = value; }
		}

		static MenuTableViewCell ()
		{
			Nib = UINib.FromName ("MenuTableViewCell", NSBundle.MainBundle);

		}

		public static MenuTableViewCell Create ()
		{
			return (MenuTableViewCell)Nib.Instantiate (null, null) [0];
		}


		public MenuTableViewCell (IntPtr handle) : base (handle)
		{
		}
	}
}
