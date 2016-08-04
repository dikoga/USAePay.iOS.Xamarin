using System;

namespace USAePay.iOS.Xamarin.Binding
{
	public enum ReturnTransactionType : uint
	{
		PinOnline,
		PinOfflineEncr,
		PinOfflinePlain,
		PinOfflineAndSignature,
		SignatureReq,
		FailCvm,
		NoCvmReq,
		NoCvmAvail
	}
}

