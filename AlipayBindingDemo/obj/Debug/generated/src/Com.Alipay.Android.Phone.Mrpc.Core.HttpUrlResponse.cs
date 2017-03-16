using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/HttpUrlResponse", DoNotGenerateAcw=true)]
	public partial class HttpUrlResponse : global::Com.Alipay.Android.Phone.Mrpc.Core.Response {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/HttpUrlResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpUrlResponse); }
		}

		protected HttpUrlResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ILjava_lang_String_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/constructor[@name='HttpUrlResponse' and count(parameter)=4 and parameter[1][@type='com.alipay.android.phone.mrpc.core.HttpUrlHeader'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]']]"
		[Register (".ctor", "(Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;ILjava/lang/String;[B)V", "")]
		public unsafe HttpUrlResponse (global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader p0, int p1, string p2, byte[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (HttpUrlResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;ILjava/lang/String;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;ILjava/lang/String;[B)V", __args);
					return;
				}

				if (id_ctor_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ILjava_lang_String_arrayB == IntPtr.Zero)
					id_ctor_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ILjava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;ILjava/lang/String;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ILjava_lang_String_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ILjava_lang_String_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_getCharset;
#pragma warning disable 0169
		static Delegate GetGetCharsetHandler ()
		{
			if (cb_getCharset == null)
				cb_getCharset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCharset);
			return cb_getCharset;
		}

		static IntPtr n_GetCharset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Charset);
		}
#pragma warning restore 0169

		static Delegate cb_setCharset_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCharset_Ljava_lang_String_Handler ()
		{
			if (cb_setCharset_Ljava_lang_String_ == null)
				cb_setCharset_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCharset_Ljava_lang_String_);
			return cb_setCharset_Ljava_lang_String_;
		}

		static void n_SetCharset_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Charset = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCharset;
		static IntPtr id_setCharset_Ljava_lang_String_;
		public virtual unsafe string Charset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='getCharset' and count(parameter)=0]"
			[Register ("getCharset", "()Ljava/lang/String;", "GetGetCharsetHandler")]
			get {
				if (id_getCharset == IntPtr.Zero)
					id_getCharset = JNIEnv.GetMethodID (class_ref, "getCharset", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCharset), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCharset", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='setCharset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCharset", "(Ljava/lang/String;)V", "GetSetCharset_Ljava_lang_String_Handler")]
			set {
				if (id_setCharset_Ljava_lang_String_ == IntPtr.Zero)
					id_setCharset_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCharset", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCharset_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCharset", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		public virtual unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getCreateTime;
#pragma warning disable 0169
		static Delegate GetGetCreateTimeHandler ()
		{
			if (cb_getCreateTime == null)
				cb_getCreateTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCreateTime);
			return cb_getCreateTime;
		}

		static long n_GetCreateTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateTime;
		}
#pragma warning restore 0169

		static Delegate cb_setCreateTime_J;
#pragma warning disable 0169
		static Delegate GetSetCreateTime_JHandler ()
		{
			if (cb_setCreateTime_J == null)
				cb_setCreateTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCreateTime_J);
			return cb_setCreateTime_J;
		}

		static void n_SetCreateTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreateTime;
		static IntPtr id_setCreateTime_J;
		public virtual unsafe long CreateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='getCreateTime' and count(parameter)=0]"
			[Register ("getCreateTime", "()J", "GetGetCreateTimeHandler")]
			get {
				if (id_getCreateTime == IntPtr.Zero)
					id_getCreateTime = JNIEnv.GetMethodID (class_ref, "getCreateTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCreateTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreateTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='setCreateTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCreateTime", "(J)V", "GetSetCreateTime_JHandler")]
			set {
				if (id_setCreateTime_J == IntPtr.Zero)
					id_setCreateTime_J = JNIEnv.GetMethodID (class_ref, "setCreateTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCreateTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreateTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeader;
#pragma warning disable 0169
		static Delegate GetGetHeaderHandler ()
		{
			if (cb_getHeader == null)
				cb_getHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeader);
			return cb_getHeader;
		}

		static IntPtr n_GetHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Header);
		}
#pragma warning restore 0169

		static Delegate cb_setHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_;
#pragma warning disable 0169
		static Delegate GetSetHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_Handler ()
		{
			if (cb_setHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ == null)
				cb_setHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_);
			return cb_setHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_;
		}

		static void n_SetHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Header = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeader;
		static IntPtr id_setHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_;
		public virtual unsafe global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader Header {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='getHeader' and count(parameter)=0]"
			[Register ("getHeader", "()Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;", "GetGetHeaderHandler")]
			get {
				if (id_getHeader == IntPtr.Zero)
					id_getHeader = JNIEnv.GetMethodID (class_ref, "getHeader", "()Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeader), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlHeader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeader", "()Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='setHeader' and count(parameter)=1 and parameter[1][@type='com.alipay.android.phone.mrpc.core.HttpUrlHeader']]"
			[Register ("setHeader", "(Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;)V", "GetSetHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_Handler")]
			set {
				if (id_setHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ == IntPtr.Zero)
					id_setHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_ = JNIEnv.GetMethodID (class_ref, "setHeader", "(Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeader_Lcom_alipay_android_phone_mrpc_core_HttpUrlHeader_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeader", "(Lcom/alipay/android/phone/mrpc/core/HttpUrlHeader;)V"), __args);
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
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Msg);
		}
#pragma warning restore 0169

		static IntPtr id_getMsg;
		public virtual unsafe string Msg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='getMsg' and count(parameter)=0]"
			[Register ("getMsg", "()Ljava/lang/String;", "GetGetMsgHandler")]
			get {
				if (id_getMsg == IntPtr.Zero)
					id_getMsg = JNIEnv.GetMethodID (class_ref, "getMsg", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMsg), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsg", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPeriod;
#pragma warning disable 0169
		static Delegate GetGetPeriodHandler ()
		{
			if (cb_getPeriod == null)
				cb_getPeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPeriod);
			return cb_getPeriod;
		}

		static long n_GetPeriod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Period;
		}
#pragma warning restore 0169

		static Delegate cb_setPeriod_J;
#pragma warning disable 0169
		static Delegate GetSetPeriod_JHandler ()
		{
			if (cb_setPeriod_J == null)
				cb_setPeriod_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetPeriod_J);
			return cb_setPeriod_J;
		}

		static void n_SetPeriod_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.HttpUrlResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Period = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPeriod;
		static IntPtr id_setPeriod_J;
		public virtual unsafe long Period {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='getPeriod' and count(parameter)=0]"
			[Register ("getPeriod", "()J", "GetGetPeriodHandler")]
			get {
				if (id_getPeriod == IntPtr.Zero)
					id_getPeriod = JNIEnv.GetMethodID (class_ref, "getPeriod", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPeriod);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeriod", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpUrlResponse']/method[@name='setPeriod' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setPeriod", "(J)V", "GetSetPeriod_JHandler")]
			set {
				if (id_setPeriod_J == IntPtr.Zero)
					id_setPeriod_J = JNIEnv.GetMethodID (class_ref, "setPeriod", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPeriod_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPeriod", "(J)V"), __args);
				} finally {
				}
			}
		}

	}
}
