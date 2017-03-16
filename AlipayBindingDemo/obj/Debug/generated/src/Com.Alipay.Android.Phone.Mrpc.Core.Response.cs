using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Response']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/Response", DoNotGenerateAcw=true)]
	public partial class Response : global::Java.Lang.Object {


		static IntPtr mContentType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Response']/field[@name='mContentType']"
		[Register ("mContentType")]
		protected string MContentType {
			get {
				if (mContentType_jfieldId == IntPtr.Zero)
					mContentType_jfieldId = JNIEnv.GetFieldID (class_ref, "mContentType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContentType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContentType_jfieldId == IntPtr.Zero)
					mContentType_jfieldId = JNIEnv.GetFieldID (class_ref, "mContentType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContentType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mResData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Response']/field[@name='mResData']"
		[Register ("mResData")]
		protected IList<byte> MResData {
			get {
				if (mResData_jfieldId == IntPtr.Zero)
					mResData_jfieldId = JNIEnv.GetFieldID (class_ref, "mResData", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mResData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mResData_jfieldId == IntPtr.Zero)
					mResData_jfieldId = JNIEnv.GetFieldID (class_ref, "mResData", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mResData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/Response", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Response); }
		}

		protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Response']/constructor[@name='Response' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Response ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Response)) {
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

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Response __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static Delegate cb_setContentType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentType_Ljava_lang_String_Handler ()
		{
			if (cb_setContentType_Ljava_lang_String_ == null)
				cb_setContentType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentType_Ljava_lang_String_);
			return cb_setContentType_Ljava_lang_String_;
		}

		static void n_SetContentType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Response __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		static IntPtr id_setContentType_Ljava_lang_String_;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Response']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Response']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentType", "(Ljava/lang/String;)V", "GetSetContentType_Ljava_lang_String_Handler")]
			set {
				if (id_setContentType_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResData;
#pragma warning disable 0169
		static Delegate GetGetResDataHandler ()
		{
			if (cb_getResData == null)
				cb_getResData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResData);
			return cb_getResData;
		}

		static IntPtr n_GetResData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Response __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetResData ());
		}
#pragma warning restore 0169

		static IntPtr id_getResData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Response']/method[@name='getResData' and count(parameter)=0]"
		[Register ("getResData", "()[B", "GetGetResDataHandler")]
		public virtual unsafe byte[] GetResData ()
		{
			if (id_getResData == IntPtr.Zero)
				id_getResData = JNIEnv.GetMethodID (class_ref, "getResData", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResData), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setResData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetResData_arrayBHandler ()
		{
			if (cb_setResData_arrayB == null)
				cb_setResData_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResData_arrayB);
			return cb_setResData_arrayB;
		}

		static void n_SetResData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Response __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetResData (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResData_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Response']/method[@name='setResData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setResData", "([B)V", "GetSetResData_arrayBHandler")]
		public virtual unsafe void SetResData (byte[] p0)
		{
			if (id_setResData_arrayB == IntPtr.Zero)
				id_setResData_arrayB = JNIEnv.GetMethodID (class_ref, "setResData", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResData_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResData", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
