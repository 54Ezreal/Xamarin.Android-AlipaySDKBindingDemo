using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Mobilesecuritysdk.Face {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.mobilesecuritysdk.face']/class[@name='SecurityClientMobile']"
	[global::Android.Runtime.Register ("com/alipay/mobilesecuritysdk/face/SecurityClientMobile", DoNotGenerateAcw=true)]
	public partial class SecurityClientMobile : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/mobilesecuritysdk/face/SecurityClientMobile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SecurityClientMobile); }
		}

		protected SecurityClientMobile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.mobilesecuritysdk.face']/class[@name='SecurityClientMobile']/constructor[@name='SecurityClientMobile' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SecurityClientMobile ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SecurityClientMobile)) {
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

		static IntPtr id_GetApdid_Landroid_content_Context_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.mobilesecuritysdk.face']/class[@name='SecurityClientMobile']/method[@name='GetApdid' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("GetApdid", "(Landroid/content/Context;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetApdid (global::Android.Content.Context p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_GetApdid_Landroid_content_Context_Ljava_util_Map_ == IntPtr.Zero)
				id_GetApdid_Landroid_content_Context_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "GetApdid", "(Landroid/content/Context;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_GetApdid_Landroid_content_Context_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
