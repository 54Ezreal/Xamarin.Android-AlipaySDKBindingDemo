using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlHeader']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/HttpUrlHeader", DoNotGenerateAcw=true)]
	public partial class HttpUrlHeader : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/HttpUrlHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpUrlHeader); }
		}

		protected HttpUrlHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlHeader']/constructor[@name='HttpUrlHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpUrlHeader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HttpUrlHeader)) {
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
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static Delegate cb_setHeaders_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetHeaders_Ljava_util_Map_Handler ()
		{
			if (cb_setHeaders_Ljava_util_Map_ == null)
				cb_setHeaders_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaders_Ljava_util_Map_);
			return cb_setHeaders_Ljava_util_Map_;
		}

		static void n_SetHeaders_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Headers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		static IntPtr id_setHeaders_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlHeader']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlHeader']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setHeaders", "(Ljava/util/Map;)V", "GetSetHeaders_Ljava_util_Map_Handler")]
			set {
				if (id_setHeaders_Ljava_util_Map_ == IntPtr.Zero)
					id_setHeaders_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setHeaders", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaders_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaders", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHead_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetHead_Ljava_lang_String_Handler ()
		{
			if (cb_getHead_Ljava_lang_String_ == null)
				cb_getHead_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetHead_Ljava_lang_String_);
			return cb_getHead_Ljava_lang_String_;
		}

		static IntPtr n_GetHead_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetHead (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getHead_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlHeader']/method[@name='getHead' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHead", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetHead_Ljava_lang_String_Handler")]
		public virtual unsafe string GetHead (string p0)
		{
			if (id_getHead_Ljava_lang_String_ == IntPtr.Zero)
				id_getHead_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getHead", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHead_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHead", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setHead_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHead_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setHead_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setHead_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHead_Ljava_lang_String_Ljava_lang_String_);
			return cb_setHead_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetHead_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetHead (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setHead_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlHeader']/method[@name='setHead' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setHead", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetHead_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetHead (string p0, string p1)
		{
			if (id_setHead_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setHead_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHead", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHead_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHead", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
