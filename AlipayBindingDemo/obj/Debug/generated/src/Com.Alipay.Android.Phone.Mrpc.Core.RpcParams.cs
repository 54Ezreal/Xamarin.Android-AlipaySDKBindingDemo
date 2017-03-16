using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcParams']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/RpcParams", DoNotGenerateAcw=true)]
	public partial class RpcParams : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/RpcParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RpcParams); }
		}

		protected RpcParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcParams']/constructor[@name='RpcParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RpcParams ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RpcParams)) {
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

		static Delegate cb_getGwUrl;
#pragma warning disable 0169
		static Delegate GetGetGwUrlHandler ()
		{
			if (cb_getGwUrl == null)
				cb_getGwUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGwUrl);
			return cb_getGwUrl;
		}

		static IntPtr n_GetGwUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GwUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setGwUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGwUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setGwUrl_Ljava_lang_String_ == null)
				cb_setGwUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGwUrl_Ljava_lang_String_);
			return cb_setGwUrl_Ljava_lang_String_;
		}

		static void n_SetGwUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GwUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGwUrl;
		static IntPtr id_setGwUrl_Ljava_lang_String_;
		public virtual unsafe string GwUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcParams']/method[@name='getGwUrl' and count(parameter)=0]"
			[Register ("getGwUrl", "()Ljava/lang/String;", "GetGetGwUrlHandler")]
			get {
				if (id_getGwUrl == IntPtr.Zero)
					id_getGwUrl = JNIEnv.GetMethodID (class_ref, "getGwUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGwUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGwUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcParams']/method[@name='setGwUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGwUrl", "(Ljava/lang/String;)V", "GetSetGwUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setGwUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setGwUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGwUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGwUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGwUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isGzip;
#pragma warning disable 0169
		static Delegate GetIsGzipHandler ()
		{
			if (cb_isGzip == null)
				cb_isGzip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGzip);
			return cb_isGzip;
		}

		static bool n_IsGzip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Gzip;
		}
#pragma warning restore 0169

		static Delegate cb_setGzip_Z;
#pragma warning disable 0169
		static Delegate GetSetGzip_ZHandler ()
		{
			if (cb_setGzip_Z == null)
				cb_setGzip_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetGzip_Z);
			return cb_setGzip_Z;
		}

		static void n_SetGzip_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Gzip = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isGzip;
		static IntPtr id_setGzip_Z;
		public virtual unsafe bool Gzip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcParams']/method[@name='isGzip' and count(parameter)=0]"
			[Register ("isGzip", "()Z", "GetIsGzipHandler")]
			get {
				if (id_isGzip == IntPtr.Zero)
					id_isGzip = JNIEnv.GetMethodID (class_ref, "isGzip", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isGzip);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGzip", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcParams']/method[@name='setGzip' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGzip", "(Z)V", "GetSetGzip_ZHandler")]
			set {
				if (id_setGzip_Z == IntPtr.Zero)
					id_setGzip_Z = JNIEnv.GetMethodID (class_ref, "setGzip", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGzip_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGzip", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static Delegate cb_setHeaders_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetHeaders_Ljava_util_List_Handler ()
		{
			if (cb_setHeaders_Ljava_util_List_ == null)
				cb_setHeaders_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaders_Ljava_util_List_);
			return cb_setHeaders_Ljava_util_List_;
		}

		static void n_SetHeaders_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Headers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		static IntPtr id_setHeaders_Ljava_util_List_;
		public virtual unsafe global::System.Collections.IList Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcParams']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/List;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcParams']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
			[Register ("setHeaders", "(Ljava/util/List;)V", "GetSetHeaders_Ljava_util_List_Handler")]
			set {
				if (id_setHeaders_Ljava_util_List_ == IntPtr.Zero)
					id_setHeaders_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setHeaders", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaders_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaders", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
