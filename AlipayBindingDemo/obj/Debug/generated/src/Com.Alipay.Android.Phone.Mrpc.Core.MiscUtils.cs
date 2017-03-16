using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='MiscUtils']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/MiscUtils", DoNotGenerateAcw=true)]
	public sealed partial class MiscUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='MiscUtils']/field[@name='RC_PACKAGE_NAME']"
		[Register ("RC_PACKAGE_NAME")]
		public const string RcPackageName = (string) "com.eg.android.AlipayGphoneRC";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/MiscUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MiscUtils); }
		}

		internal MiscUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='MiscUtils']/constructor[@name='MiscUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MiscUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MiscUtils)) {
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

		static IntPtr id_isDebugger_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='MiscUtils']/method[@name='isDebugger' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isDebugger", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsDebugger (global::Android.Content.Context p0)
		{
			if (id_isDebugger_Landroid_content_Context_ == IntPtr.Zero)
				id_isDebugger_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isDebugger", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDebugger_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
