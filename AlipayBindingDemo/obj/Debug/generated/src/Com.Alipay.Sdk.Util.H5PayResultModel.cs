using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.sdk.util']/class[@name='H5PayResultModel']"
	[global::Android.Runtime.Register ("com/alipay/sdk/util/H5PayResultModel", DoNotGenerateAcw=true)]
	public partial class H5PayResultModel : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/sdk/util/H5PayResultModel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (H5PayResultModel); }
		}

		protected H5PayResultModel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.sdk.util']/class[@name='H5PayResultModel']/constructor[@name='H5PayResultModel' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe H5PayResultModel ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (H5PayResultModel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getResultCode;
#pragma warning disable 0169
		static Delegate GetGetResultCodeHandler ()
		{
			if (cb_getResultCode == null)
				cb_getResultCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResultCode);
			return cb_getResultCode;
		}

		static IntPtr n_GetResultCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Sdk.Util.H5PayResultModel __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.Util.H5PayResultModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResultCode);
		}
#pragma warning restore 0169

		static Delegate cb_setResultCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResultCode_Ljava_lang_String_Handler ()
		{
			if (cb_setResultCode_Ljava_lang_String_ == null)
				cb_setResultCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResultCode_Ljava_lang_String_);
			return cb_setResultCode_Ljava_lang_String_;
		}

		static void n_SetResultCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Sdk.Util.H5PayResultModel __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.Util.H5PayResultModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResultCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResultCode;
		static IntPtr id_setResultCode_Ljava_lang_String_;
		public virtual unsafe string ResultCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.util']/class[@name='H5PayResultModel']/method[@name='getResultCode' and count(parameter)=0]"
			[Register ("getResultCode", "()Ljava/lang/String;", "GetGetResultCodeHandler")]
			get {
				if (id_getResultCode == IntPtr.Zero)
					id_getResultCode = JNIEnv.GetMethodID (class_ref, "getResultCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResultCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResultCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.util']/class[@name='H5PayResultModel']/method[@name='setResultCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResultCode", "(Ljava/lang/String;)V", "GetSetResultCode_Ljava_lang_String_Handler")]
			set {
				if (id_setResultCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setResultCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResultCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResultCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResultCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReturnUrl;
#pragma warning disable 0169
		static Delegate GetGetReturnUrlHandler ()
		{
			if (cb_getReturnUrl == null)
				cb_getReturnUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReturnUrl);
			return cb_getReturnUrl;
		}

		static IntPtr n_GetReturnUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Sdk.Util.H5PayResultModel __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.Util.H5PayResultModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReturnUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setReturnUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReturnUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setReturnUrl_Ljava_lang_String_ == null)
				cb_setReturnUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReturnUrl_Ljava_lang_String_);
			return cb_setReturnUrl_Ljava_lang_String_;
		}

		static void n_SetReturnUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Sdk.Util.H5PayResultModel __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.Util.H5PayResultModel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReturnUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReturnUrl;
		static IntPtr id_setReturnUrl_Ljava_lang_String_;
		public virtual unsafe string ReturnUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.util']/class[@name='H5PayResultModel']/method[@name='getReturnUrl' and count(parameter)=0]"
			[Register ("getReturnUrl", "()Ljava/lang/String;", "GetGetReturnUrlHandler")]
			get {
				if (id_getReturnUrl == IntPtr.Zero)
					id_getReturnUrl = JNIEnv.GetMethodID (class_ref, "getReturnUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReturnUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReturnUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.util']/class[@name='H5PayResultModel']/method[@name='setReturnUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setReturnUrl", "(Ljava/lang/String;)V", "GetSetReturnUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setReturnUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setReturnUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReturnUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReturnUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReturnUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
