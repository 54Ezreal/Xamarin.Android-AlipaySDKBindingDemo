using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper2']"
	[global::Android.Runtime.Register ("com/ta/utdid2/device/UTUtdidHelper2", DoNotGenerateAcw=true)]
	public partial class UTUtdidHelper2 : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/device/UTUtdidHelper2", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTUtdidHelper2); }
		}

		protected UTUtdidHelper2 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper2']/constructor[@name='UTUtdidHelper2' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTUtdidHelper2 ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTUtdidHelper2)) {
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

		static Delegate cb_dePack_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDePack_Ljava_lang_String_Handler ()
		{
			if (cb_dePack_Ljava_lang_String_ == null)
				cb_dePack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DePack_Ljava_lang_String_);
			return cb_dePack_Ljava_lang_String_;
		}

		static IntPtr n_DePack_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Device.UTUtdidHelper2 __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.UTUtdidHelper2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DePack (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dePack_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper2']/method[@name='dePack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dePack", "(Ljava/lang/String;)Ljava/lang/String;", "GetDePack_Ljava_lang_String_Handler")]
		public virtual unsafe string DePack (string p0)
		{
			if (id_dePack_Ljava_lang_String_ == IntPtr.Zero)
				id_dePack_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "dePack", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dePack_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dePack", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_dePackWithBase64_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDePackWithBase64_Ljava_lang_String_Handler ()
		{
			if (cb_dePackWithBase64_Ljava_lang_String_ == null)
				cb_dePackWithBase64_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DePackWithBase64_Ljava_lang_String_);
			return cb_dePackWithBase64_Ljava_lang_String_;
		}

		static IntPtr n_DePackWithBase64_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Device.UTUtdidHelper2 __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.UTUtdidHelper2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DePackWithBase64 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dePackWithBase64_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper2']/method[@name='dePackWithBase64' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dePackWithBase64", "(Ljava/lang/String;)Ljava/lang/String;", "GetDePackWithBase64_Ljava_lang_String_Handler")]
		public virtual unsafe string DePackWithBase64 (string p0)
		{
			if (id_dePackWithBase64_Ljava_lang_String_ == IntPtr.Zero)
				id_dePackWithBase64_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "dePackWithBase64", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dePackWithBase64_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dePackWithBase64", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
