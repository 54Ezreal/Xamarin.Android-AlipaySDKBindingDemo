using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcCaller']"
	[Register ("com/alipay/android/phone/mrpc/core/RpcCaller", "", "Com.Alipay.Android.Phone.Mrpc.Core.IRpcCallerInvoker")]
	public partial interface IRpcCaller : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcCaller']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/Object;", "GetCallHandler:Com.Alipay.Android.Phone.Mrpc.Core.IRpcCallerInvoker, AlipayBindingDemo")]
		global::Java.Lang.Object Call ();

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/RpcCaller", DoNotGenerateAcw=true)]
	internal class IRpcCallerInvoker : global::Java.Lang.Object, IRpcCaller {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/RpcCaller");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRpcCallerInvoker); }
		}

		IntPtr class_ref;

		public static IRpcCaller GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRpcCaller> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.android.phone.mrpc.core.RpcCaller"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRpcCallerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_call;
#pragma warning disable 0169
		static Delegate GetCallHandler ()
		{
			if (cb_call == null)
				cb_call = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Call);
			return cb_call;
		}

		static IntPtr n_Call (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.IRpcCaller __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IRpcCaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		IntPtr id_call;
		public unsafe global::Java.Lang.Object Call ()
		{
			if (id_call == IntPtr.Zero)
				id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
		}

	}

}
