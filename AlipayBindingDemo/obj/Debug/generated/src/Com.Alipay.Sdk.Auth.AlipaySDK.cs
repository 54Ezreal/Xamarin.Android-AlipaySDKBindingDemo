using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Sdk.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.sdk.auth']/class[@name='AlipaySDK']"
	[global::Android.Runtime.Register ("com/alipay/sdk/auth/AlipaySDK", DoNotGenerateAcw=true)]
	public partial class AlipaySDK : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/sdk/auth/AlipaySDK", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlipaySDK); }
		}

		protected AlipaySDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.sdk.auth']/class[@name='AlipaySDK']/constructor[@name='AlipaySDK' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlipaySDK ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AlipaySDK)) {
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

		static IntPtr id_auth_Landroid_app_Activity_Lcom_alipay_sdk_auth_APAuthInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.auth']/class[@name='AlipaySDK']/method[@name='auth' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.alipay.sdk.auth.APAuthInfo']]"
		[Register ("auth", "(Landroid/app/Activity;Lcom/alipay/sdk/auth/APAuthInfo;)V", "")]
		public static unsafe void Auth (global::Android.App.Activity p0, global::Com.Alipay.Sdk.Auth.APAuthInfo p1)
		{
			if (id_auth_Landroid_app_Activity_Lcom_alipay_sdk_auth_APAuthInfo_ == IntPtr.Zero)
				id_auth_Landroid_app_Activity_Lcom_alipay_sdk_auth_APAuthInfo_ = JNIEnv.GetStaticMethodID (class_ref, "auth", "(Landroid/app/Activity;Lcom/alipay/sdk/auth/APAuthInfo;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_auth_Landroid_app_Activity_Lcom_alipay_sdk_auth_APAuthInfo_, __args);
			} finally {
			}
		}

	}
}
