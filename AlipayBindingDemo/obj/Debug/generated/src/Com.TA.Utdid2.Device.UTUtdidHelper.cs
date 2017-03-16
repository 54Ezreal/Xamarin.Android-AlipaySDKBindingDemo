using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper']"
	[global::Android.Runtime.Register ("com/ta/utdid2/device/UTUtdidHelper", DoNotGenerateAcw=true)]
	public partial class UTUtdidHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/device/UTUtdidHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UTUtdidHelper); }
		}

		protected UTUtdidHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper']/constructor[@name='UTUtdidHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UTUtdidHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UTUtdidHelper)) {
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
			global::Com.TA.Utdid2.Device.UTUtdidHelper __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.UTUtdidHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DePack (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_dePack_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper']/method[@name='dePack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_generateRandomUTDID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper']/method[@name='generateRandomUTDID' and count(parameter)=0]"
		[Register ("generateRandomUTDID", "()Ljava/lang/String;", "")]
		public static unsafe string GenerateRandomUTDID ()
		{
			if (id_generateRandomUTDID == IntPtr.Zero)
				id_generateRandomUTDID = JNIEnv.GetStaticMethodID (class_ref, "generateRandomUTDID", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateRandomUTDID), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pack_arrayB;
#pragma warning disable 0169
		static Delegate GetPack_arrayBHandler ()
		{
			if (cb_pack_arrayB == null)
				cb_pack_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Pack_arrayB);
			return cb_pack_arrayB;
		}

		static IntPtr n_Pack_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Device.UTUtdidHelper __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.UTUtdidHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewString (__this.Pack (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_pack_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper']/method[@name='pack' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("pack", "([B)Ljava/lang/String;", "GetPack_arrayBHandler")]
		public virtual unsafe string Pack (byte[] p0)
		{
			if (id_pack_arrayB == IntPtr.Zero)
				id_pack_arrayB = JNIEnv.GetMethodID (class_ref, "pack", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pack_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pack", "([B)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_packUtdidStr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPackUtdidStr_Ljava_lang_String_Handler ()
		{
			if (cb_packUtdidStr_Ljava_lang_String_ == null)
				cb_packUtdidStr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PackUtdidStr_Ljava_lang_String_);
			return cb_packUtdidStr_Ljava_lang_String_;
		}

		static IntPtr n_PackUtdidStr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Device.UTUtdidHelper __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.UTUtdidHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PackUtdidStr (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_packUtdidStr_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='UTUtdidHelper']/method[@name='packUtdidStr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("packUtdidStr", "(Ljava/lang/String;)Ljava/lang/String;", "GetPackUtdidStr_Ljava_lang_String_Handler")]
		public virtual unsafe string PackUtdidStr (string p0)
		{
			if (id_packUtdidStr_Ljava_lang_String_ == IntPtr.Zero)
				id_packUtdidStr_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "packUtdidStr", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_packUtdidStr_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "packUtdidStr", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
