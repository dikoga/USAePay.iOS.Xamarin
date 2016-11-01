using System;
using Foundation;
using USAePay.iOS.Xamarin.Binding;
using UIKit;
using SignaturePad;
using CoreGraphics;

namespace USAePay.iOS.Xamarin.Sample
{
	public partial class ViewController : UIViewController
	{
		public usaepayMiddleware CardReader;
		public MiddlewareSettings CardReaderSettings;
		public CardReaderDelegate CardReaderCallback;
		public const string AMOUNT = "0.11";
		private SignaturePadView signature;

		protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			CardReader = usaepayMiddleware.Instance;
			CardReaderSettings = MiddlewareSettings.Instance;
			//CardReaderSettings.SetMode ("sandbox");
			CardReaderSettings.SourceKey = "rOk1PeN3ye6IN0Y3ZkZ1yb3hQc7u2HY3";
			CardReaderSettings.PinNum = "ht402ht";
			CardReaderCallback = new CardReaderDelegate(UpdateStatus, RefNumCallback);
			CardReader.SetDevice("icmp", CardReaderCallback);
		}

		partial void GetDeviceInfoButton_TouchUpInside (UIButton sender)
		{
			if (!CardReader.IsDeviceOnline)
			{
				UpdateStatus("DeviceInfo", "Device is not on-line...");
				return;
			}

			UpdateStatus("DeviceInfo", CardReader.DeviceInfo.ToString());
		}

		public void UpdateStatus(string methodName, string msg)
		{
			InvokeOnMainThread(() =>
			{
				StatusText.Text += Environment.NewLine;
				StatusText.Text += "------- begin " + methodName + " -------";
				StatusText.Text += Environment.NewLine;
				StatusText.Text += msg;
				StatusText.Text += Environment.NewLine;
				StatusText.Text += "------- end " + methodName + " -------";
				StatusText.Text += Environment.NewLine;
				StatusText.ScrollRangeToVisible(new NSRange(StatusText.Text.Length - 1, 1));
			});
		}

		public void RefNumCallback(string refnum, bool captureSignature)
		{
			InvokeOnMainThread(() =>
			{
				RefNumText.Text = refnum;
				if (captureSignature)
					CaptureSignature();
			});
		}

		private void CaptureSignature()
		{
			signature = new SignaturePadView(new CGRect(100, 100, 400, 400))
			{
				StrokeWidth = 3f
			};
			var button = new UIButton(UIButtonType.RoundedRect);
			button.Frame = new CGRect(400, 505, 100, 50);
			button.SetTitle("Done", UIControlState.Normal);
			button.BackgroundColor = UIColor.DarkGray;
			button.TouchUpInside += (sender, e) => {
				if (signature.IsBlank)
				{
					return;
				}

				var image = signature.GetImage();
				var imageEncoded = image.AsJPEG().GetBase64EncodedString(NSDataBase64EncodingOptions.None);

				var capture = new NSMutableDictionary();

				capture.Add(NSObject.FromObject("signature"), NSObject.FromObject(imageEncoded));
				capture.Add(NSObject.FromObject("refNum"), NSObject.FromObject(RefNumText.Text));
				capture.Add(NSObject.FromObject("amount"), NSObject.FromObject(AMOUNT));
				capture.Add(NSObject.FromObject("command"), NSObject.FromObject("capture"));

				CardReader.CaptureSignature(capture);

				button.RemoveFromSuperview();
				signature.RemoveFromSuperview();
			};

			View.AddSubview(signature);
			View.AddSubview(button);
		}

		partial void ConnectButton_TouchUpInside(UIButton sender)
		{
			CardReader.ConnectDevice();

			if (!CardReader.IsDeviceOnline)
				CardReader.GoOnline();
		}

		partial void DisconnectButton_TouchUpInside(UIButton sender)
		{
			CardReader.DisconnectDevice();
			CardReader.GoOffline();
		}

		partial void ChargeCardButton_TouchUpInside(UIButton sender)
		{
			if (!CardReader.IsDeviceOnline)
			{
				UpdateStatus("DeviceInfo", "Device is not on-line...");
				return;
			}

			var sale = new NSMutableDictionary();
			sale.Add(NSObject.FromObject("amount"), NSObject.FromObject(AMOUNT));
			sale.Add(NSObject.FromObject("command"), NSObject.FromObject("cc:sale"));

			CardReader.StartTransaction(sale);
		}

		partial void RefundButton_TouchUpInside(UIButton sender)
		{
			if (!CardReader.IsDeviceOnline)
			{
				UpdateStatus("DeviceInfo", "Device is not on-line...");
				return;
			}

			var sale = new NSMutableDictionary();
			sale.Add(NSObject.FromObject("amount"), NSObject.FromObject(AMOUNT));
			sale.Add(NSObject.FromObject("command"), NSObject.FromObject("creditvoid"));
			sale.Add(NSObject.FromObject("refnum"), NSObject.FromObject(RefNumText.Text));

			CardReader.StartTransaction(sale);
		}
	}
}

