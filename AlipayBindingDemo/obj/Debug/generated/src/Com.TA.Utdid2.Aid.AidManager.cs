using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Aid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.aid']/class[@name='AidManager']"
	[global::Android.Runtime.Register ("com/ta/utdid2/aid/AidManager", DoNotGenerateAcw=true)]
	public partial class AidManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/aid/AidManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AidManager); }
		}

		protected AidManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.aid']/class[@name='AidManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/ta/utdid2/aid/AidManager;", "")]
		public static unsafe global::Com.TA.Utdid2.Aid.AidManager GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/ta/utdid2/aid/AidManager;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.TA.Utdid2.Aid.AidManager __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Aid.AidManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.TA.Utdid2.Aid.AidManager __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Aid.AidManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetValue (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.aid']/class[@name='AidManager']/method[@name='getValue' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetValue (string p0, string p1, string p2)
		{
			if (id_getValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_requestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_;
#pragma warning disable 0169
		static Delegate GetRequestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_Handler ()
		{
			if (cb_requestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ == null)
				cb_requestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_);
			return cb_requestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_;
		}

		static void n_RequestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.TA.Utdid2.Aid.AidManager __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Aid.AidManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Device.IAidCallback p3 = (global::Com.UT.Device.IAidCallback)global::Java.Lang.Object.GetObject<global::Com.UT.Device.IAidCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.RequestAid (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_requestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.aid']/class[@name='AidManager']/method[@name='requestAid' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.ut.device.AidCallback']]"
		[Register ("requestAid", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/ut/device/AidCallback;)V", "GetRequestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_Handler")]
		public virtual unsafe void RequestAid (string p0, string p1, string p2, global::Com.UT.Device.IAidCallback p3)
		{
			if (id_requestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ == IntPtr.Zero)
				id_requestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ = JNIEnv.GetMethodID (class_ref, "requestAid", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/ut/device/AidCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestAid_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestAid", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/ut/device/AidCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
