using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Aid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.aid']/class[@name='AidRequester']"
	[global::Android.Runtime.Register ("com/ta/utdid2/aid/AidRequester", DoNotGenerateAcw=true)]
	public partial class AidRequester : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/aid/AidRequester", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AidRequester); }
		}

		protected AidRequester (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.aid']/class[@name='AidRequester']/constructor[@name='AidRequester' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AidRequester (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AidRequester)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.aid']/class[@name='AidRequester']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/ta/utdid2/aid/AidRequester;", "")]
		public static unsafe global::Com.TA.Utdid2.Aid.AidRequester GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/ta/utdid2/aid/AidRequester;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.TA.Utdid2.Aid.AidRequester __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Aid.AidRequester> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_postRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPostRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_postRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_postRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_postRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PostRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.TA.Utdid2.Aid.AidRequester __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Aid.AidRequester> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PostRest (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_postRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.aid']/class[@name='AidRequester']/method[@name='postRest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("postRest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetPostRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string PostRest (string p0, string p1, string p2, string p3)
		{
			if (id_postRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_postRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "postRest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postRest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postRest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_postRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_;
#pragma warning disable 0169
		static Delegate GetPostRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_Handler ()
		{
			if (cb_postRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ == null)
				cb_postRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_);
			return cb_postRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_;
		}

		static void n_PostRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.TA.Utdid2.Aid.AidRequester __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Aid.AidRequester> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.UT.Device.IAidCallback p4 = (global::Com.UT.Device.IAidCallback)global::Java.Lang.Object.GetObject<global::Com.UT.Device.IAidCallback> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.PostRestAsync (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_postRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.aid']/class[@name='AidRequester']/method[@name='postRestAsync' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.ut.device.AidCallback']]"
		[Register ("postRestAsync", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/ut/device/AidCallback;)V", "GetPostRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_Handler")]
		public virtual unsafe void PostRestAsync (string p0, string p1, string p2, string p3, global::Com.UT.Device.IAidCallback p4)
		{
			if (id_postRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ == IntPtr.Zero)
				id_postRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_ = JNIEnv.GetMethodID (class_ref, "postRestAsync", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/ut/device/AidCallback;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_postRestAsync_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_ut_device_AidCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postRestAsync", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/ut/device/AidCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
