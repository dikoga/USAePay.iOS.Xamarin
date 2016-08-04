using System;
using USAePay.iOS.Xamarin.Binding;

namespace USAePay.iOS.Xamarin.Sample
{
	public class CardReaderDelegate : usaepayMiddlewareDelegate
	{
		public CardReaderDelegate ()
		{
		}

		public override void CaptureSignatureComplete (usaepayTransactionResponse transResponse)
		{
			Console.WriteLine (transResponse);
		}

		public override void TransactionComplete (usaepayTransactionResponse transResponse)
		{
			Console.WriteLine (transResponse);
		}

		public override void DeviceConnected ()
		{
			Console.WriteLine ("DeviceConnected");
		}

		public override void DeviceDisconnected ()
		{
			Console.WriteLine ("DeviceDisconnected");
		}
	}
}

