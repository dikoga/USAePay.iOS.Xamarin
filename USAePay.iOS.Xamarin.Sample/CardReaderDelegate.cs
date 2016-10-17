using System;
using System.Text;
using Newtonsoft.Json;
using USAePay.iOS.Xamarin.Binding;

namespace USAePay.iOS.Xamarin.Sample
{
	public class CardReaderDelegate : usaepayMiddlewareDelegate
	{
		private Action<string, string> _statusCallback;
		private Action<string, bool> _refNumCallback;

		public CardReaderDelegate (Action<string, string> statusCallback, Action<string, bool> refNumCallback)
		{
			_statusCallback = statusCallback;
			_refNumCallback = refNumCallback;
		}

		public override void CaptureSignatureComplete (usaepayTransactionResponse transResponse)
		{
			_statusCallback("CaptureSignatureComplete", FormatLog(transResponse));
		}

		public override void TransactionComplete (usaepayTransactionResponse transResponse)
		{
			if (transResponse == null)
			{
				_statusCallback("TransactionComplete", "Null response");
				return;
			}

			_statusCallback("TransactionComplete", FormatLog(transResponse));
		}

		public override void DeviceConnected()
		{
			_statusCallback("DeviceConnected", "DeviceConnected");
		}

		public override void DeviceDisconnected ()
		{
			//This is not being called by the SDK...
			_statusCallback("DeviceDisconnected", "DeviceDisconnected");
		}

		private string FormatLog(usaepayTransactionResponse transResponse)
		{

			var sb = new StringBuilder();
			sb.AppendFormat("AuthAmount: {0}{1}", transResponse.AuthAmount, Environment.NewLine);
			sb.AppendFormat("AuthCode: {0}{1}", transResponse.AuthCode, Environment.NewLine);
			sb.AppendFormat("AvsResult: {0}{1}", transResponse.AvsResult, Environment.NewLine);
			sb.AppendFormat("AvsResultCode: {0}{1}", transResponse.AvsResultCode, Environment.NewLine);
			sb.AppendFormat("BatchNum: {0}{1}", transResponse.BatchNum, Environment.NewLine);
			sb.AppendFormat("BatchRefNum: {0}{1}", transResponse.BatchRefNum, Environment.NewLine);
			sb.AppendFormat("CardCodeResult: {0}{1}", transResponse.CardCodeResult, Environment.NewLine);
			sb.AppendFormat("CardCodeResultCode: {0}{1}", transResponse.CardCodeResultCode, Environment.NewLine);
			sb.AppendFormat("CardReadResult: {0}{1}", transResponse.CardReadResult, Environment.NewLine);
			sb.AppendFormat("CustNum: {0}{1}", transResponse.CustNum, Environment.NewLine);
			sb.AppendFormat("Error: {0}{1}", transResponse.Error, Environment.NewLine);
			sb.AppendFormat("ErrorCode: {0}{1}", transResponse.ErrorCode, Environment.NewLine);
			sb.AppendFormat("RefNum: {0}{1}", transResponse.RefNum, Environment.NewLine);
			sb.AppendFormat("RemainBalance: {0}{1}", transResponse.RemainBalance, Environment.NewLine);
			sb.AppendFormat("Result: {0}{1}", transResponse.Result, Environment.NewLine);
			sb.AppendFormat("ResultCode: {0}{1}", transResponse.ResultCode, Environment.NewLine);
			sb.AppendFormat("Status: {0}{1}", transResponse.Status, Environment.NewLine);
			sb.AppendFormat("StatusCode: {0}{1}", transResponse.StatusCode, Environment.NewLine);
			sb.AppendFormat("ReceiptInfo: {0}{1}", transResponse.ReceiptInfo, Environment.NewLine);

			if (transResponse.ReceiptInfo != null)
			{
				sb.AppendFormat("ReceiptInfo.Amount: {0}{1}", transResponse.ReceiptInfo.Amount, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.AuthCode: {0}{1}", transResponse.ReceiptInfo.AuthCode, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.CardHolderName: {0}{1}", transResponse.ReceiptInfo.CardHolderName, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.CardType: {0}{1}", transResponse.ReceiptInfo.CardType, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.Command: {0}{1}", transResponse.ReceiptInfo.Command, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.CvmResults: {0}{1}", transResponse.ReceiptInfo.CvmResults, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.InvoiceNum: {0}{1}", transResponse.ReceiptInfo.InvoiceNum, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.MaskedCardNum: {0}{1}", transResponse.ReceiptInfo.MaskedCardNum, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.RefNum: {0}{1}", transResponse.ReceiptInfo.RefNum, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TaxAMount: {0}{1}", transResponse.ReceiptInfo.TaxAMount, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TerminalSerialNum: {0}{1}", transResponse.ReceiptInfo.TerminalSerialNum, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TipAmount: {0}{1}", transResponse.ReceiptInfo.TipAmount, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TransAID: {0}{1}", transResponse.ReceiptInfo.TransAID, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TransAIDName: {0}{1}", transResponse.ReceiptInfo.TransAIDName, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TransResult: {0}{1}", transResponse.ReceiptInfo.TransResult, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TransError: {0}{1}", transResponse.ReceiptInfo.TransError, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TransCounter: {0}{1}", transResponse.ReceiptInfo.TransCounter, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TransDataSource: {0}{1}", transResponse.ReceiptInfo.TransDataSource, Environment.NewLine);
				sb.AppendFormat("ReceiptInfo.TransResponseCode: {0}{1}", transResponse.ReceiptInfo.TransResponseCode, Environment.NewLine);
				var captureSignature = transResponse.ReceiptInfo.CvmResults == ReturnTransactionType.SignatureReq;
				_refNumCallback(transResponse.ReceiptInfo.RefNum, captureSignature);
			}

			Console.Write(sb.ToString());

			return sb.ToString();
		}
	}
}

