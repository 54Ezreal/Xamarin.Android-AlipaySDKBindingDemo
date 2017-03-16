using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.UT.Device {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ut.device']/interface[@name='AidCallback']"
	[Register ("com/ut/device/AidCallback", "", "Com.UT.Device.IAidCallbackInvoker")]
	public partial interface IAidCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ut.device']/interface[@name='AidCallback']/method[@name='onAidEventChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAidEventChanged", "(ILjava/lang/String;)V", "GetOnAidEventChanged_ILjava_lang_String_Handler:Com.UT.Device.IAidCallbackInvoker, AlipayBindingDemo")]
		void OnAidEventChanged (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/ut/device/AidCallback", DoNotGenerateAcw=true)]
	internal class IAidCallbackInvoker : global::Java.Lang.Object, IAidCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ut/device/AidCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAidCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IAidCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ut.device.AidCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAidEventChanged_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAidEventChanged_ILjava_lang_String_Handler ()
		{
			if (cb_onAidEventChanged_ILjava_lang_String_ == null)
				cb_onAidEventChanged_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnAidEventChanged_ILjava_lang_String_);
			return cb_onAidEventChanged_ILjava_lang_String_;
		}

		static void n_OnAidEventChanged_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.UT.Device.IAidCallback __this = global::Java.Lang.Object.GetObject<global::Com.UT.Device.IAidCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAidEventChanged (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAidEventChanged_ILjava_lang_String_;
		public unsafe void OnAidEventChanged (int p0, string p1)
		{
			if (id_onAidEventChanged_ILjava_lang_String_ == IntPtr.Zero)
				id_onAidEventChanged_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAidEventChanged", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAidEventChanged_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
