using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdid']"
	[global::Android.Runtime.Register ("com/ta/utdid2/device/UTUtdid", DoNotGenerateAcw=true)]
	public partial class UTUtdid : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/device/UTUtdid", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTUtdid); }
		}

		protected UTUtdid (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdid']/constructor[@name='UTUtdid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe UTUtdid (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (UTUtdid)) {
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

		static Delegate cb_getValue;
#pragma warning disable 0169
		static Delegate GetGetValueHandler ()
		{
			if (cb_getValue == null)
				cb_getValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue);
			return cb_getValue;
		}

		static IntPtr n_GetValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Device.UTUtdid __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.UTUtdid> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value);
		}
#pragma warning restore 0169

		static IntPtr id_getValue;
		public virtual unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdid']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_instance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdid']/method[@name='instance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("instance", "(Landroid/content/Context;)Lcom/ta/utdid2/device/UTUtdid;", "")]
		public static unsafe global::Com.TA.Utdid2.Device.UTUtdid Instance (global::Android.Content.Context p0)
		{
			if (id_instance_Landroid_content_Context_ == IntPtr.Zero)
				id_instance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "instance", "(Landroid/content/Context;)Lcom/ta/utdid2/device/UTUtdid;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.TA.Utdid2.Device.UTUtdid __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.UTUtdid> (JNIEnv.CallStaticObjectMethod  (class_ref, id_instance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
