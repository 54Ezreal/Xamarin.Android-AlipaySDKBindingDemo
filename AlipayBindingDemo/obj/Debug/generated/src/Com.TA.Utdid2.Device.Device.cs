using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Device {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='Device']"
	[global::Android.Runtime.Register ("com/ta/utdid2/device/Device", DoNotGenerateAcw=true)]
	public partial class Device : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/device/Device", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Device); }
		}

		protected Device (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='Device']/constructor[@name='Device' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Device ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Device)) {
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

		static Delegate cb_getDeviceId;
#pragma warning disable 0169
		static Delegate GetGetDeviceIdHandler ()
		{
			if (cb_getDeviceId == null)
				cb_getDeviceId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceId);
			return cb_getDeviceId;
		}

		static IntPtr n_GetDeviceId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Device.Device __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.Device> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceId);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceId;
		public virtual unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='Device']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImei;
#pragma warning disable 0169
		static Delegate GetGetImeiHandler ()
		{
			if (cb_getImei == null)
				cb_getImei = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImei);
			return cb_getImei;
		}

		static IntPtr n_GetImei (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Device.Device __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.Device> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Imei);
		}
#pragma warning restore 0169

		static IntPtr id_getImei;
		public virtual unsafe string Imei {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='Device']/method[@name='getImei' and count(parameter)=0]"
			[Register ("getImei", "()Ljava/lang/String;", "GetGetImeiHandler")]
			get {
				if (id_getImei == IntPtr.Zero)
					id_getImei = JNIEnv.GetMethodID (class_ref, "getImei", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImei), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImei", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getImsi;
#pragma warning disable 0169
		static Delegate GetGetImsiHandler ()
		{
			if (cb_getImsi == null)
				cb_getImsi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImsi);
			return cb_getImsi;
		}

		static IntPtr n_GetImsi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Device.Device __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.Device> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Imsi);
		}
#pragma warning restore 0169

		static IntPtr id_getImsi;
		public virtual unsafe string Imsi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='Device']/method[@name='getImsi' and count(parameter)=0]"
			[Register ("getImsi", "()Ljava/lang/String;", "GetGetImsiHandler")]
			get {
				if (id_getImsi == IntPtr.Zero)
					id_getImsi = JNIEnv.GetMethodID (class_ref, "getImsi", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImsi), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImsi", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUtdid;
#pragma warning disable 0169
		static Delegate GetGetUtdidHandler ()
		{
			if (cb_getUtdid == null)
				cb_getUtdid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUtdid);
			return cb_getUtdid;
		}

		static IntPtr n_GetUtdid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Device.Device __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Device.Device> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Utdid);
		}
#pragma warning restore 0169

		static IntPtr id_getUtdid;
		public virtual unsafe string Utdid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.device']/class[@name='Device']/method[@name='getUtdid' and count(parameter)=0]"
			[Register ("getUtdid", "()Ljava/lang/String;", "GetGetUtdidHandler")]
			get {
				if (id_getUtdid == IntPtr.Zero)
					id_getUtdid = JNIEnv.GetMethodID (class_ref, "getUtdid", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUtdid), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUtdid", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
