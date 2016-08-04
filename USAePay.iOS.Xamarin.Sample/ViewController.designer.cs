// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace USAePay.iOS.Xamarin.Sample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GetCardInfoButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GetDeviceInfoButton { get; set; }

        [Action ("GetCardInfoButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GetCardInfoButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("GetDeviceInfoButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GetDeviceInfoButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (GetCardInfoButton != null) {
                GetCardInfoButton.Dispose ();
                GetCardInfoButton = null;
            }

            if (GetDeviceInfoButton != null) {
                GetDeviceInfoButton.Dispose ();
                GetDeviceInfoButton = null;
            }
        }
    }
}