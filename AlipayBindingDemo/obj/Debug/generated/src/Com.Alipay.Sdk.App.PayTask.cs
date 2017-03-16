using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Sdk.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='PayTask']"
	[global::Android.Runtime.Register ("com/alipay/sdk/app/PayTask", DoNotGenerateAcw=true)]
	public partial class PayTask : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/sdk/app/PayTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayTask); }
		}

		protected PayTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='PayTask']/constructor[@name='PayTask' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe PayTask (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PayTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Sdk.App.PayTask __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.PayTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='PayTask']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_fetchOrderInfoFromH5PayUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFetchOrderInfoFromH5PayUrl_Ljava_lang_String_Handler ()
		{
			if (cb_fetchOrderInfoFromH5PayUrl_Ljava_lang_String_ == null)
				cb_fetchOrderInfoFromH5PayUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FetchOrderInfoFromH5PayUrl_Ljava_lang_String_);
			return cb_fetchOrderInfoFromH5PayUrl_Ljava_lang_String_;
		}

		static IntPtr n_FetchOrderInfoFromH5PayUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Sdk.App.PayTask __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.PayTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.FetchOrderInfoFromH5PayUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_fetchOrderInfoFromH5PayUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='PayTask']/method[@name='fetchOrderInfoFromH5PayUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fetchOrderInfoFromH5PayUrl", "(Ljava/lang/String;)Ljava/lang/String;", "GetFetchOrderInfoFromH5PayUrl_Ljava_lang_String_Handler")]
		public virtual unsafe string FetchOrderInfoFromH5PayUrl (string p0)
		{
			if (id_fetchOrderInfoFromH5PayUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_fetchOrderInfoFromH5PayUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fetchOrderInfoFromH5PayUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fetchOrderInfoFromH5PayUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetchOrderInfoFromH5PayUrl", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_fetchTradeToken;
#pragma warning disable 0169
		static Delegate GetFetchTradeTokenHandler ()
		{
			if (cb_fetchTradeToken == null)
				cb_fetchTradeToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FetchTradeToken);
			return cb_fetchTradeToken;
		}

		static IntPtr n_FetchTradeToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Sdk.App.PayTask __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.PayTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FetchTradeToken ());
		}
#pragma warning restore 0169

		static IntPtr id_fetchTradeToken;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='PayTask']/method[@name='fetchTradeToken' and count(parameter)=0]"
		[Register ("fetchTradeToken", "()Ljava/lang/String;", "GetFetchTradeTokenHandler")]
		public virtual unsafe string FetchTradeToken ()
		{
			if (id_fetchTradeToken == IntPtr.Zero)
				id_fetchTradeToken = JNIEnv.GetMethodID (class_ref, "fetchTradeToken", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fetchTradeToken), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetchTradeToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_h5Pay_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetH5Pay_Ljava_lang_String_ZHandler ()
		{
			if (cb_h5Pay_Ljava_lang_String_Z == null)
				cb_h5Pay_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_H5Pay_Ljava_lang_String_Z);
			return cb_h5Pay_Ljava_lang_String_Z;
		}

		static IntPtr n_H5Pay_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Alipay.Sdk.App.PayTask __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.PayTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.H5Pay (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_h5Pay_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='PayTask']/method[@name='h5Pay' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("h5Pay", "(Ljava/lang/String;Z)Lcom/alipay/sdk/util/H5PayResultModel;", "GetH5Pay_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Com.Alipay.Sdk.Util.H5PayResultModel H5Pay (string p0, bool p1)
		{
			if (id_h5Pay_Ljava_lang_String_Z == IntPtr.Zero)
				id_h5Pay_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "h5Pay", "(Ljava/lang/String;Z)Lcom/alipay/sdk/util/H5PayResultModel;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Alipay.Sdk.Util.H5PayResultModel __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.Util.H5PayResultModel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_h5Pay_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.Util.H5PayResultModel> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "h5Pay", "(Ljava/lang/String;Z)Lcom/alipay/sdk/util/H5PayResultModel;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_pay_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPay_Ljava_lang_String_ZHandler ()
		{
			if (cb_pay_Ljava_lang_String_Z == null)
				cb_pay_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_Pay_Ljava_lang_String_Z);
			return cb_pay_Ljava_lang_String_Z;
		}

		static IntPtr n_Pay_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Alipay.Sdk.App.PayTask __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.PayTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Pay (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_pay_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='PayTask']/method[@name='pay' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("pay", "(Ljava/lang/String;Z)Ljava/lang/String;", "GetPay_Ljava_lang_String_ZHandler")]
		public virtual unsafe string Pay (string p0, bool p1)
		{
			if (id_pay_Ljava_lang_String_Z == IntPtr.Zero)
				id_pay_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "pay", "(Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pay_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pay", "(Ljava/lang/String;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_payV2_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPayV2_Ljava_lang_String_ZHandler ()
		{
			if (cb_payV2_Ljava_lang_String_Z == null)
				cb_payV2_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_PayV2_Ljava_lang_String_Z);
			return cb_payV2_Ljava_lang_String_Z;
		}

		static IntPtr n_PayV2_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Alipay.Sdk.App.PayTask __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.PayTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.PayV2 (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_payV2_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='PayTask']/method[@name='payV2' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("payV2", "(Ljava/lang/String;Z)Ljava/util/Map;", "GetPayV2_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> PayV2 (string p0, bool p1)
		{
			if (id_payV2_Ljava_lang_String_Z == IntPtr.Zero)
				id_payV2_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "payV2", "(Ljava/lang/String;Z)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::System.Collections.Generic.IDictionary<string, string> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_payV2_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "payV2", "(Ljava/lang/String;Z)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
