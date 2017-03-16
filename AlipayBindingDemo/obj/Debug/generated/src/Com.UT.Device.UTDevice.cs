using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']"
	[global::Android.Runtime.Register ("com/ut/device/UTDevice", DoNotGenerateAcw=true)]
	public partial class UTDevice : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ut/device/UTDevice", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']/constructor[@name='UTDevice' and count(parameter)=0]"
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

		static IntPtr id_getAid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']/method[@name='getAid' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("getAid", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAid (string p0, string p1, global::Android.Content.Context p2)
		{
			if (id_getAid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getAid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAid", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAid_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getAidAsync_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Lcom_ut_device_AidCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']/method[@name='getAidAsync' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context'] and parameter[4][@type='com.ut.device.AidCallback']]"
		[Register ("getAidAsync", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;Lcom/ut/device/AidCallback;)V", "")]
		public static unsafe void GetAidAsync (string p0, string p1, global::Android.Content.Context p2, global::Com.UT.Device.IAidCallback p3)
		{
			if (id_getAidAsync_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Lcom_ut_device_AidCallback_ == IntPtr.Zero)
				id_getAidAsync_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Lcom_ut_device_AidCallback_ = JNIEnv.GetStaticMethodID (class_ref, "getAidAsync", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;Lcom/ut/device/AidCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getAidAsync_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_Lcom_ut_device_AidCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getUtdid_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.device']/class[@name='UTDevice']/method[@name='getUtdid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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
