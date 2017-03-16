using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Sdk.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils']"
	[global::Android.Runtime.Register ("com/alipay/sdk/app/EnvUtils", DoNotGenerateAcw=true)]
	public partial class EnvUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils.EnvEnum']"
		[global::Android.Runtime.Register ("com/alipay/sdk/app/EnvUtils$EnvEnum", DoNotGenerateAcw=true)]
		public sealed partial class EnvEnum : global::Java.Lang.Enum {


			static IntPtr ONLINE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils.EnvEnum']/field[@name='ONLINE']"
			[Register ("ONLINE")]
			public static global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum Online {
				get {
					if (ONLINE_jfieldId == IntPtr.Zero)
						ONLINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONLINE", "Lcom/alipay/sdk/app/EnvUtils$EnvEnum;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONLINE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SANDBOX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils.EnvEnum']/field[@name='SANDBOX']"
			[Register ("SANDBOX")]
			public static global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum Sandbox {
				get {
					if (SANDBOX_jfieldId == IntPtr.Zero)
						SANDBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SANDBOX", "Lcom/alipay/sdk/app/EnvUtils$EnvEnum;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SANDBOX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/alipay/sdk/app/EnvUtils$EnvEnum", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EnvEnum); }
			}

			internal EnvEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils.EnvEnum']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/alipay/sdk/app/EnvUtils$EnvEnum;", "")]
			public static unsafe global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/alipay/sdk/app/EnvUtils$EnvEnum;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum __ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils.EnvEnum']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/alipay/sdk/app/EnvUtils$EnvEnum;", "")]
			public static unsafe global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/alipay/sdk/app/EnvUtils$EnvEnum;");
				try {
					return (global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/sdk/app/EnvUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EnvUtils); }
		}

		protected EnvUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils']/constructor[@name='EnvUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnvUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (EnvUtils)) {
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

		static IntPtr id_isSandBox;
		public static unsafe bool IsSandBox {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils']/method[@name='isSandBox' and count(parameter)=0]"
			[Register ("isSandBox", "()Z", "GetIsSandBoxHandler")]
			get {
				if (id_isSandBox == IntPtr.Zero)
					id_isSandBox = JNIEnv.GetStaticMethodID (class_ref, "isSandBox", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSandBox);
				} finally {
				}
			}
		}

		static IntPtr id_geEnv;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils']/method[@name='geEnv' and count(parameter)=0]"
		[Register ("geEnv", "()Lcom/alipay/sdk/app/EnvUtils$EnvEnum;", "")]
		public static unsafe global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum GeEnv ()
		{
			if (id_geEnv == IntPtr.Zero)
				id_geEnv = JNIEnv.GetStaticMethodID (class_ref, "geEnv", "()Lcom/alipay/sdk/app/EnvUtils$EnvEnum;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum> (JNIEnv.CallStaticObjectMethod  (class_ref, id_geEnv), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setEnv_Lcom_alipay_sdk_app_EnvUtils_EnvEnum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='EnvUtils']/method[@name='setEnv' and count(parameter)=1 and parameter[1][@type='com.alipay.sdk.app.EnvUtils.EnvEnum']]"
		[Register ("setEnv", "(Lcom/alipay/sdk/app/EnvUtils$EnvEnum;)V", "")]
		public static unsafe void SetEnv (global::Com.Alipay.Sdk.App.EnvUtils.EnvEnum p0)
		{
			if (id_setEnv_Lcom_alipay_sdk_app_EnvUtils_EnvEnum_ == IntPtr.Zero)
				id_setEnv_Lcom_alipay_sdk_app_EnvUtils_EnvEnum_ = JNIEnv.GetStaticMethodID (class_ref, "setEnv", "(Lcom/alipay/sdk/app/EnvUtils$EnvEnum;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnv_Lcom_alipay_sdk_app_EnvUtils_EnvEnum_, __args);
			} finally {
			}
		}

	}
}
