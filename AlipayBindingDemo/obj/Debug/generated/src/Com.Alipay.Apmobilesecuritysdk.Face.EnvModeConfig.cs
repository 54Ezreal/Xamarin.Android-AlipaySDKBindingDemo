using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Apmobilesecuritysdk.Face {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='EnvModeConfig']"
	[global::Android.Runtime.Register ("com/alipay/apmobilesecuritysdk/face/EnvModeConfig", DoNotGenerateAcw=true)]
	public partial class EnvModeConfig : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='EnvModeConfig']/field[@name='ENVIRONMENT_AAA']"
		[Register ("ENVIRONMENT_AAA")]
		public const int EnvironmentAaa = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='EnvModeConfig']/field[@name='ENVIRONMENT_DAILY']"
		[Register ("ENVIRONMENT_DAILY")]
		public const int EnvironmentDaily = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='EnvModeConfig']/field[@name='ENVIRONMENT_ONLINE']"
		[Register ("ENVIRONMENT_ONLINE")]
		public const int EnvironmentOnline = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='EnvModeConfig']/field[@name='ENVIRONMENT_PRE']"
		[Register ("ENVIRONMENT_PRE")]
		public const int EnvironmentPre = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='EnvModeConfig']/field[@name='ENVIRONMENT_SIT']"
		[Register ("ENVIRONMENT_SIT")]
		public const int EnvironmentSit = (int) 3;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/apmobilesecuritysdk/face/EnvModeConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EnvModeConfig); }
		}

		protected EnvModeConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='EnvModeConfig']/constructor[@name='EnvModeConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnvModeConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EnvModeConfig)) {
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

	}
}
