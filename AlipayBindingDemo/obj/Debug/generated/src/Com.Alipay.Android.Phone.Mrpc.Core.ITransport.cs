using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='Transport']"
	[Register ("com/alipay/android/phone/mrpc/core/Transport", "", "Com.Alipay.Android.Phone.Mrpc.Core.ITransportInvoker")]
	public partial interface ITransport : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='Transport']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.alipay.android.phone.mrpc.core.Request']]"
		[Register ("execute", "(Lcom/alipay/android/phone/mrpc/core/Request;)Ljava/util/concurrent/Future;", "GetExecute_Lcom_alipay_android_phone_mrpc_core_Request_Handler:Com.Alipay.Android.Phone.Mrpc.Core.ITransportInvoker, AlipayBindingDemo")]
		global::Java.Util.Concurrent.IFuture Execute (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0);

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/Transport", DoNotGenerateAcw=true)]
	internal class ITransportInvoker : global::Java.Lang.Object, ITransport {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/Transport");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITransportInvoker); }
		}

		IntPtr class_ref;

		public static ITransport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.android.phone.mrpc.core.Transport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_execute_Lcom_alipay_android_phone_mrpc_core_Request_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_alipay_android_phone_mrpc_core_Request_Handler ()
		{
			if (cb_execute_Lcom_alipay_android_phone_mrpc_core_Request_ == null)
				cb_execute_Lcom_alipay_android_phone_mrpc_core_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Execute_Lcom_alipay_android_phone_mrpc_core_Request_);
			return cb_execute_Lcom_alipay_android_phone_mrpc_core_Request_;
		}

		static IntPtr n_Execute_Lcom_alipay_android_phone_mrpc_core_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.ITransport __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_execute_Lcom_alipay_android_phone_mrpc_core_Request_;
		public unsafe global::Java.Util.Concurrent.IFuture Execute (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0)
		{
			if (id_execute_Lcom_alipay_android_phone_mrpc_core_Request_ == IntPtr.Zero)
				id_execute_Lcom_alipay_android_phone_mrpc_core_Request_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/alipay/android/phone/mrpc/core/Request;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Util.Concurrent.IFuture __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute_Lcom_alipay_android_phone_mrpc_core_Request_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
