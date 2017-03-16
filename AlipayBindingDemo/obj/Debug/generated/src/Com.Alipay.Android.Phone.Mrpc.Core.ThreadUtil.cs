using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='ThreadUtil']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/ThreadUtil", DoNotGenerateAcw=true)]
	public partial class ThreadUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/ThreadUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreadUtil); }
		}

		protected ThreadUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='ThreadUtil']/constructor[@name='ThreadUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ThreadUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ThreadUtil)) {
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

		static IntPtr id_checkMainThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='ThreadUtil']/method[@name='checkMainThread' and count(parameter)=0]"
		[Register ("checkMainThread", "()Z", "")]
		public static unsafe bool CheckMainThread ()
		{
			if (id_checkMainThread == IntPtr.Zero)
				id_checkMainThread = JNIEnv.GetStaticMethodID (class_ref, "checkMainThread", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_checkMainThread);
			} finally {
			}
		}

	}
}
