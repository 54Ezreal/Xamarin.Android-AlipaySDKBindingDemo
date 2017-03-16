using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/HttpException", DoNotGenerateAcw=true)]
	public partial class HttpException : global::Java.Lang.Exception {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_AUTH_ERROR']"
		[Register ("NETWORK_AUTH_ERROR")]
		public const int NetworkAuthError = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_CONNECTION_EXCEPTION']"
		[Register ("NETWORK_CONNECTION_EXCEPTION")]
		public const int NetworkConnectionException = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_DNS_ERROR']"
		[Register ("NETWORK_DNS_ERROR")]
		public const int NetworkDnsError = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_IO_EXCEPTION']"
		[Register ("NETWORK_IO_EXCEPTION")]
		public const int NetworkIoException = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_SCHEDULE_ERROR']"
		[Register ("NETWORK_SCHEDULE_ERROR")]
		public const int NetworkScheduleError = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_SERVER_EXCEPTION']"
		[Register ("NETWORK_SERVER_EXCEPTION")]
		public const int NetworkServerException = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_SOCKET_EXCEPTION']"
		[Register ("NETWORK_SOCKET_EXCEPTION")]
		public const int NetworkSocketException = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_SSL_EXCEPTION']"
		[Register ("NETWORK_SSL_EXCEPTION")]
		public const int NetworkSslException = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_UNAVAILABLE']"
		[Register ("NETWORK_UNAVAILABLE")]
		public const int NetworkUnavailable = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/field[@name='NETWORK_UNKNOWN_ERROR']"
		[Register ("NETWORK_UNKNOWN_ERROR")]
		public const int NetworkUnknownError = (int) 0;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/HttpException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpException); }
		}

		protected HttpException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/constructor[@name='HttpException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HttpException (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (HttpException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/constructor[@name='HttpException' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Integer;Ljava/lang/String;)V", "")]
		public unsafe HttpException (global::Java.Lang.Integer p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (HttpException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Integer;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/Integer;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCode);
			return cb_getCode;
		}

		static int n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpException __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		public virtual unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Throwable) this).Handle, id_getCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMsg;
#pragma warning disable 0169
		static Delegate GetGetMsgHandler ()
		{
			if (cb_getMsg == null)
				cb_getMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMsg);
			return cb_getMsg;
		}

		static IntPtr n_GetMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpException __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Msg);
		}
#pragma warning restore 0169

		static IntPtr id_getMsg;
		public virtual unsafe string Msg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpException']/method[@name='getMsg' and count(parameter)=0]"
			[Register ("getMsg", "()Ljava/lang/String;", "GetGetMsgHandler")]
			get {
				if (id_getMsg == IntPtr.Zero)
					id_getMsg = JNIEnv.GetMethodID (class_ref, "getMsg", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getMsg), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsg", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
