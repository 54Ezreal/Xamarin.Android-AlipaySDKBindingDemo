using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64Helper']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/Base64Helper", DoNotGenerateAcw=true)]
	public partial class Base64Helper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/Base64Helper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64Helper); }
		}

		protected Base64Helper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64Helper']/constructor[@name='Base64Helper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Base64Helper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Base64Helper)) {
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

		static IntPtr id_encodeToString_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64Helper']/method[@name='encodeToString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encodeToString", "([BI)Ljava/lang/String;", "")]
		public static unsafe string EncodeToString (byte[] p0, int p1)
		{
			if (id_encodeToString_arrayBI == IntPtr.Zero)
				id_encodeToString_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encodeToString", "([BI)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeToString_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
