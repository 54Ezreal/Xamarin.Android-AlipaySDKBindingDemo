using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpDateTime']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/HttpDateTime", DoNotGenerateAcw=true)]
	public sealed partial class HttpDateTime : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpDateTime.TimeOfDay']"
		[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/HttpDateTime$TimeOfDay", DoNotGenerateAcw=true)]
		public partial class TimeOfDay : global::Java.Lang.Object {

			protected TimeOfDay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/HttpDateTime", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpDateTime); }
		}

		internal HttpDateTime (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpDateTime']/constructor[@name='HttpDateTime' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpDateTime ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (HttpDateTime)) {
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

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='HttpDateTime']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)J", "")]
		public static unsafe long Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_parse_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
