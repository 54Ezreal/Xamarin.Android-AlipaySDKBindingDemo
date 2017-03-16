using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTDevice']"
	[global::Android.Runtime.Register ("com/ta/utdid2/device/UTDevice", DoNotGenerateAcw=true)]
	public partial class UTDevice : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/device/UTDevice", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTDevice); }
		}

		protected UTDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTDevice']/constructor[@name='UTDevice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTDevice ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTDevice)) {
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

		static IntPtr id_getUtdid_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTDevice']/method[@name='getUtdid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUtdid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetUtdid (global::Android.Content.Context p0)
		{
			if (id_getUtdid_Landroid_content_Context_ == IntPtr.Zero)
				id_getUtdid_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUtdid", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUtdid_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
