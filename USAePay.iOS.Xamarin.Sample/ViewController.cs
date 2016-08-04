using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Foundation;
using UIKit;

namespace USAePay.iOS.Xamarin.Sample
{
	public partial class ViewController : UIViewController
	{
		protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			Console.WriteLine (AppDelegate.CardReader.IsDeviceOnline);
			if (!AppDelegate.CardReader.IsDeviceOnline)
				AppDelegate.CardReader.GoOnline ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.

		}

		partial void GetCardInfoButton_TouchUpInside (UIButton sender)
		{
			//AppDelegate.CardReader.GoOffline ();
			var sale = new NSMutableDictionary ();
			sale.Add (NSObject.FromObject ("amount"), NSObject.FromObject ("40.00"));
			sale.Add (NSObject.FromObject ("command"), NSObject.FromObject ("cc:sale"));

			AppDelegate.CardReader.StartTransaction (sale);
		}

		partial void GetDeviceInfoButton_TouchUpInside (UIButton sender)
		{
			Console.WriteLine (AppDelegate.CardReader.DeviceInfo);
		}
	}
}

