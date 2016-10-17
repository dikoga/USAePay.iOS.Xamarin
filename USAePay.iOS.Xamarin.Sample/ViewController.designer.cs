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
        UIKit.UIButton ChargeCardButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ConnectButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DisconnectButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GetDeviceInfoButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField RefNumText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RefundButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView StatusText { get; set; }

        [Action ("ChargeCardButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ChargeCardButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ConnectButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ConnectButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("DisconnectButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DisconnectButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("GetDeviceInfoButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void GetDeviceInfoButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("RefundButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RefundButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ChargeCardButton != null) {
                ChargeCardButton.Dispose ();
                ChargeCardButton = null;
            }

            if (ConnectButton != null) {
                ConnectButton.Dispose ();
                ConnectButton = null;
            }

            if (DisconnectButton != null) {
                DisconnectButton.Dispose ();
                DisconnectButton = null;
            }

            if (GetDeviceInfoButton != null) {
                GetDeviceInfoButton.Dispose ();
                GetDeviceInfoButton = null;
            }

            if (RefNumText != null) {
                RefNumText.Dispose ();
                RefNumText = null;
            }

            if (RefundButton != null) {
                RefundButton.Dispose ();
                RefundButton = null;
            }

            if (StatusText != null) {
                StatusText.Dispose ();
                StatusText = null;
            }
        }
    }
}