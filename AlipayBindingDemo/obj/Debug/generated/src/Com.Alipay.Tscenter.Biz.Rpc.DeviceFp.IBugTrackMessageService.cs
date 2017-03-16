using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.DeviceFp {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.deviceFp']/interface[@name='BugTrackMessageService']"
	[Register ("com/alipay/tscenter/biz/rpc/deviceFp/BugTrackMessageService", "", "Com.Alipay.Tscenter.Biz.Rpc.DeviceFp.IBugTrackMessageServiceInvoker")]
	public partial interface IBugTrackMessageService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.deviceFp']/interface[@name='BugTrackMessageService']/method[@name='logCollect' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logCollect", "(Ljava/lang/String;)Ljava/lang/String;", "GetLogCollect_Ljava_lang_String_Handler:Com.Alipay.Tscenter.Biz.Rpc.DeviceFp.IBugTrackMessageServiceInvoker, AlipayBindingDemo")]
		string LogCollect (string p0);

	}

	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/deviceFp/BugTrackMessageService", DoNotGenerateAcw=true)]
	internal class IBugTrackMessageServiceInvoker : global::Java.Lang.Object, IBugTrackMessageService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/deviceFp/BugTrackMessageService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBugTrackMessageServiceInvoker); }
		}

		IntPtr class_ref;

		public static IBugTrackMessageService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBugTrackMessageService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.tscenter.biz.rpc.deviceFp.BugTrackMessageService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBugTrackMessageServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_logCollect_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLogCollect_Ljava_lang_String_Handler ()
		{
			if (cb_logCollect_Ljava_lang_String_ == null)
				cb_logCollect_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LogCollect_Ljava_lang_String_);
			return cb_logCollect_Ljava_lang_String_;
		}

		static IntPtr n_LogCollect_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Tscenter.Biz.Rpc.DeviceFp.IBugTrackMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.DeviceFp.IBugTrackMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.LogCollect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_logCollect_Ljava_lang_String_;
		public unsafe string LogCollect (string p0)
		{
			if (id_logCollect_Ljava_lang_String_ == IntPtr.Zero)
				id_logCollect_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "logCollect", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_logCollect_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
