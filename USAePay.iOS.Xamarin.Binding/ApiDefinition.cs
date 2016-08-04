using System;

using Foundation;
using ObjCRuntime;

namespace USAePay.iOS.Xamarin.Binding
{
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const MiddlewareLogNotification;
		[Field ("MiddlewareLogNotification", "__Internal")]
		NSString MiddlewareLogNotification { get; }

		// extern NSString *const MiddlewareFlowNotification;
		[Field ("MiddlewareFlowNotification", "__Internal")]
		NSString MiddlewareFlowNotification { get; }
	}

	// @interface MiddlewareSettings : NSObject
	[BaseType (typeof (NSObject))]
	interface MiddlewareSettings
	{
		// +(id)sharedManager;
		[Static]
		[Export ("sharedManager")]
		//[Verify (MethodToProperty)]
		MiddlewareSettings SharedManager { get; }

		// @property (readwrite, nonatomic) NSString * currentMode;
		[Export ("currentMode")]
		string CurrentMode { get; set; }

		// @property (nonatomic) BOOL isEMVEnable;
		[Export ("isEMVEnable")]
		bool IsEMVEnable { get; set; }

		// @property (nonatomic) BOOL isTipEnable;
		[Export ("isTipEnable")]
		bool IsTipEnable { get; set; }

		// @property (nonatomic) BOOL enableDebugLog;
		[Export ("enableDebugLog")]
		bool EnableDebugLog { get; set; }

		// @property (retain, nonatomic) NSString * sourceKey;
		[Export ("sourceKey", ArgumentSemantic.Retain)]
		string SourceKey { get; set; }

		// @property (retain, nonatomic) NSString * pinNum;
		[Export ("pinNum", ArgumentSemantic.Retain)]
		string PinNum { get; set; }

		// -(void)setMode:(NSString *)holdMode;
		[Export ("setMode:")]
		void SetMode (string holdMode);
	}

	// @interface ReceiptInfo : NSObject
	[BaseType (typeof (NSObject))]
	interface ReceiptInfo
	{
		// @property (retain, nonatomic) NSString * invoiceNum;
		[Export ("invoiceNum", ArgumentSemantic.Retain)]
		string InvoiceNum { get; set; }

		// @property (retain, nonatomic) NSString * transResult;
		[Export ("transResult", ArgumentSemantic.Retain)]
		string TransResult { get; set; }

		// @property (retain, nonatomic) NSString * refNum;
		[Export ("refNum", ArgumentSemantic.Retain)]
		string RefNum { get; set; }

		// @property (retain, nonatomic) NSString * transError;
		[Export ("transError", ArgumentSemantic.Retain)]
		string TransError { get; set; }

		// @property (retain, nonatomic) NSString * authCode;
		[Export ("authCode", ArgumentSemantic.Retain)]
		string AuthCode { get; set; }

		// @property (retain, nonatomic) NSString * transAID;
		[Export ("transAID", ArgumentSemantic.Retain)]
		string TransAID { get; set; }

		// @property (retain, nonatomic) NSString * transAIDName;
		[Export ("transAIDName", ArgumentSemantic.Retain)]
		string TransAIDName { get; set; }

		// @property (nonatomic) int transCounter;
		[Export ("transCounter")]
		int TransCounter { get; set; }

		// @property (retain, nonatomic) NSString * appCryptogram;
		[Export ("appCryptogram", ArgumentSemantic.Retain)]
		string AppCryptogram { get; set; }

		// @property (retain, nonatomic) NSString * terminalSerialNum;
		[Export ("terminalSerialNum", ArgumentSemantic.Retain)]
		string TerminalSerialNum { get; set; }

		// @property (retain, nonatomic) NSString * maskedCardNum;
		[Export ("maskedCardNum", ArgumentSemantic.Retain)]
		string MaskedCardNum { get; set; }

		// @property (retain, nonatomic) NSString * cardHolderName;
		[Export ("cardHolderName", ArgumentSemantic.Retain)]
		string CardHolderName { get; set; }

		// @property (retain, nonatomic) NSString * amount;
		[Export ("amount", ArgumentSemantic.Retain)]
		string Amount { get; set; }

		// @property (retain, nonatomic) NSString * tipAmount;
		[Export ("tipAmount", ArgumentSemantic.Retain)]
		string TipAmount { get; set; }

		// @property (retain, nonatomic) NSString * taxAMount;
		[Export ("taxAMount", ArgumentSemantic.Retain)]
		string TaxAMount { get; set; }

		// @property (retain, nonatomic) NSString * discountAmount;
		[Export ("discountAmount", ArgumentSemantic.Retain)]
		string DiscountAmount { get; set; }

		// @property (retain, nonatomic) NSString * command;
		[Export ("command", ArgumentSemantic.Retain)]
		string Command { get; set; }

		// @property (retain, nonatomic) NSString * transResponseCode;
		[Export ("transResponseCode", ArgumentSemantic.Retain)]
		string TransResponseCode { get; set; }

		// @property (retain, nonatomic) NSString * transDataSource;
		[Export ("transDataSource", ArgumentSemantic.Retain)]
		string TransDataSource { get; set; }

		// @property (nonatomic) ReturnTransactionType cvmResults;
		[Export ("cvmResults", ArgumentSemantic.Assign)]
		ReturnTransactionType CvmResults { get; set; }

		// @property (retain, nonatomic) NSString * cardType;
		[Export ("cardType", ArgumentSemantic.Retain)]
		string CardType { get; set; }

		// @property (retain, nonatomic) NSArray * declinedArrayTags;
		[Export ("declinedArrayTags", ArgumentSemantic.Retain)]
		//[Verify (StronglyTypedNSArray)]
		NSObject [] DeclinedArrayTags { get; set; }
	}

	// @interface usaepayTransactionResponse : NSObject
	[BaseType (typeof (NSObject))]
	interface usaepayTransactionResponse
	{
		// @property (readwrite, nonatomic) NSString * RefNum;
		[Export ("RefNum")]
		string RefNum { get; set; }

		// @property (readwrite, nonatomic) int BatchRefNum;
		[Export ("BatchRefNum")]
		int BatchRefNum { get; set; }

		// @property (readwrite, nonatomic) int BatchNum;
		[Export ("BatchNum")]
		int BatchNum { get; set; }

		// @property (retain, nonatomic) NSString * Result;
		[Export ("Result", ArgumentSemantic.Retain)]
		string Result { get; set; }

		// @property (retain, nonatomic) NSString * ResultCode;
		[Export ("ResultCode", ArgumentSemantic.Retain)]
		string ResultCode { get; set; }

		// @property (retain, nonatomic) NSString * AuthCode;
		[Export ("AuthCode", ArgumentSemantic.Retain)]
		string AuthCode { get; set; }

		// @property (retain, nonatomic) NSString * AvsResultCode;
		[Export ("AvsResultCode", ArgumentSemantic.Retain)]
		string AvsResultCode { get; set; }

		// @property (retain, nonatomic) NSString * AvsResult;
		[Export ("AvsResult", ArgumentSemantic.Retain)]
		string AvsResult { get; set; }

		// @property (retain, nonatomic) NSString * RemainBalance;
		[Export ("RemainBalance", ArgumentSemantic.Retain)]
		string RemainBalance { get; set; }

		// @property (retain, nonatomic) NSString * CardCodeResultCode;
		[Export ("CardCodeResultCode", ArgumentSemantic.Retain)]
		string CardCodeResultCode { get; set; }

		// @property (retain, nonatomic) NSString * CardCodeResult;
		[Export ("CardCodeResult", ArgumentSemantic.Retain)]
		string CardCodeResult { get; set; }

		// @property (retain, nonatomic) NSString * CardReadResult;
		[Export ("CardReadResult", ArgumentSemantic.Retain)]
		string CardReadResult { get; set; }

		// @property (readwrite, nonatomic) int ErrorCode;
		[Export ("ErrorCode")]
		int ErrorCode { get; set; }

		// @property (readwrite, nonatomic) int CustNum;
		[Export ("CustNum")]
		int CustNum { get; set; }

		// @property (retain, nonatomic) NSString * Error;
		[Export ("Error", ArgumentSemantic.Retain)]
		string Error { get; set; }

		// @property (retain, nonatomic) NSString * AcsUrl;
		[Export ("AcsUrl", ArgumentSemantic.Retain)]
		string AcsUrl { get; set; }

		// @property (retain, nonatomic) NSString * Payload;
		[Export ("Payload", ArgumentSemantic.Retain)]
		string Payload { get; set; }

		// @property (retain, nonatomic) NSString * VpasResultCode;
		[Export ("VpasResultCode", ArgumentSemantic.Retain)]
		string VpasResultCode { get; set; }

		// @property (readwrite, nonatomic) BOOL isDuplicate;
		[Export ("isDuplicate")]
		bool IsDuplicate { get; set; }

		// @property (readwrite, retain) CurrencyAmount * ConvertedAmount;
		//[Export ("ConvertedAmount", ArgumentSemantic.Retain)]
		//CurrencyAmount ConvertedAmount { get; set; }

		// @property (retain, nonatomic) NSString * ConvertedAmountCurrency;
		[Export ("ConvertedAmountCurrency", ArgumentSemantic.Retain)]
		string ConvertedAmountCurrency { get; set; }

		// @property (readwrite, retain) CurrencyAmount * ConversionRate;
		//[Export ("ConversionRate", ArgumentSemantic.Retain)]
		//CurrencyAmount ConversionRate { get; set; }

		// @property (retain, nonatomic) NSString * Status;
		[Export ("Status", ArgumentSemantic.Retain)]
		string Status { get; set; }

		// @property (retain, nonatomic) NSString * StatusCode;
		[Export ("StatusCode", ArgumentSemantic.Retain)]
		string StatusCode { get; set; }

		// @property (readwrite, retain) NSString * authAmount;
		[Export ("authAmount", ArgumentSemantic.Retain)]
		string AuthAmount { get; set; }

		// @property (retain, nonatomic) NSString * iccData;
		[Export ("iccData", ArgumentSemantic.Retain)]
		string IccData { get; set; }

		// @property (retain, nonatomic) ReceiptInfo * receiptInfo;
		[Export ("receiptInfo", ArgumentSemantic.Retain)]
		ReceiptInfo ReceiptInfo { get; set; }

		// -(id)initWithXML:(NSString *)string;
		[Export ("initWithXML:")]
		IntPtr Constructor (string @string);
	}

	// @protocol usaepayMiddlewareDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface usaepayMiddlewareDelegate
	{
		// @required -(void)transactionComplete:(usaepayTransactionResponse *)transResponse;
		[Abstract]
		[Export ("transactionComplete:")]
		void TransactionComplete (usaepayTransactionResponse transResponse);

		// @required -(void)captureSignatureComplete:(usaepayTransactionResponse *)transResponse;
		[Abstract]
		[Export ("captureSignatureComplete:")]
		void CaptureSignatureComplete (usaepayTransactionResponse transResponse);

		// @optional -(void)deviceConnected;
		[Export ("deviceConnected")]
		void DeviceConnected ();

		// @optional -(void)deviceDisconnected;
		[Export ("deviceDisconnected")]
		void DeviceDisconnected ();
	}

	// @interface usaepayMiddleware : NSObject
	[BaseType (typeof (NSObject))]
	interface usaepayMiddleware
	{
		// +(usaepayMiddleware *)getInstance;
		[Static]
		[Export ("getInstance")]
		//[Verify (MethodToProperty)]
		usaepayMiddleware Instance { get; }

		[Wrap ("WeakDelegate")]
		usaepayMiddlewareDelegate Delegate { get; set; }

		// @property (nonatomic, strong) id<usaepayMiddlewareDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// -(void)setDevice:(NSString *)deviceName :(id)setDelegate;
		[Export ("setDevice::")]
		void SetDevice (string deviceName, usaepayMiddlewareDelegate setDelegate);

		// -(BOOL)isDeviceOnline;
		[Export ("isDeviceOnline")]
		//[Verify (MethodToProperty)]
		bool IsDeviceOnline { get; }

		// -(void)disconnectDevice;
		[Export ("disconnectDevice")]
		void DisconnectDevice ();

		// -(void)connectDevice;
		[Export ("connectDevice")]
		void ConnectDevice ();

		// -(void)goOnline;
		[Export ("goOnline")]
		void GoOnline ();

		// -(void)goOffline;
		[Export ("goOffline")]
		void GoOffline ();

		// -(NSDictionary *)getDeviceInfo;
		[Export ("getDeviceInfo")]
		//[Verify (MethodToProperty)]
		NSDictionary DeviceInfo { get; }

		// -(void)startTransaction:(NSMutableDictionary *)holdTransInfo;
		[Export ("startTransaction:")]
		void StartTransaction (NSMutableDictionary holdTransInfo);

		// -(void)transactionComplete:(usaepayTransactionResponse *)transResponse;
		[Export ("transactionComplete:")]
		void TransactionComplete (usaepayTransactionResponse transResponse);

		// -(void)captureSignature:(NSMutableDictionary *)holdCaptureInfo;
		[Export ("captureSignature:")]
		void CaptureSignature (NSMutableDictionary holdCaptureInfo);

		// -(void)captureSignatureComplete:(usaepayTransactionResponse *)transResponse;
		[Export ("captureSignatureComplete:")]
		void CaptureSignatureComplete (usaepayTransactionResponse transResponse);

		// -(void)getReceipt:(NSDictionary *)receiptDict;
		[Export ("getReceipt:")]
		void GetReceipt (NSDictionary receiptDict);

		// -(void)returnReceiptCompleted:(NSString *)receiptValue;
		[Export ("returnReceiptCompleted:")]
		void ReturnReceiptCompleted (string receiptValue);
	}
}

