using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Sdk.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='H5AuthActivity']"
	[global::Android.Runtime.Register ("com/alipay/sdk/app/H5AuthActivity", DoNotGenerateAcw=true)]
	public partial class H5AuthActivity : global::Com.Alipay.Sdk.App.H5PayActivity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/sdk/app/H5AuthActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (H5AuthActivity); }
		}

		protected H5AuthActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='H5AuthActivity']/constructor[@name='H5AuthActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe H5AuthActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (H5AuthActivity)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='H5AuthActivity']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public override sealed unsafe void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_a);
			} finally {
			}
		}

	}
}
