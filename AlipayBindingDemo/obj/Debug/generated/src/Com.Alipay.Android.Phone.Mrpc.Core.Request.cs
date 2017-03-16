using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Request']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/Request", DoNotGenerateAcw=true)]
	public abstract partial class Request : global::Java.Lang.Object {


		static IntPtr mCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Request']/field[@name='mCallback']"
		[Register ("mCallback")]
		protected global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback MCallback {
			get {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/alipay/android/phone/mrpc/core/TransportCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCallback_jfieldId == IntPtr.Zero)
					mCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mCallback", "Lcom/alipay/android/phone/mrpc/core/TransportCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/Request", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Request); }
		}

		protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Request']/constructor[@name='Request' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Request ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Request)) {
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

		static Delegate cb_getCallback;
#pragma warning disable 0169
		static Delegate GetGetCallbackHandler ()
		{
			if (cb_getCallback == null)
				cb_getCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallback);
			return cb_getCallback;
		}

		static IntPtr n_GetCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Callback);
		}
#pragma warning restore 0169

		static IntPtr id_getCallback;
		public virtual unsafe global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback Callback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Request']/method[@name='getCallback' and count(parameter)=0]"
			[Register ("getCallback", "()Lcom/alipay/android/phone/mrpc/core/TransportCallback;", "GetGetCallbackHandler")]
			get {
				if (id_getCallback == IntPtr.Zero)
					id_getCallback = JNIEnv.GetMethodID (class_ref, "getCallback", "()Lcom/alipay/android/phone/mrpc/core/TransportCallback;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCallback", "()Lcom/alipay/android/phone/mrpc/core/TransportCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		static IntPtr id_isCanceled;
		public virtual unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Request']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				if (id_isCanceled == IntPtr.Zero)
					id_isCanceled = JNIEnv.GetMethodID (class_ref, "isCanceled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCanceled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCanceled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Request']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_setTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_;
#pragma warning disable 0169
		static Delegate GetSetTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_Handler ()
		{
			if (cb_setTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_ == null)
				cb_setTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_);
			return cb_setTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_;
		}

		static void n_SetTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback p0 = (global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback)global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTransportCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='Request']/method[@name='setTransportCallback' and count(parameter)=1 and parameter[1][@type='com.alipay.android.phone.mrpc.core.TransportCallback']]"
		[Register ("setTransportCallback", "(Lcom/alipay/android/phone/mrpc/core/TransportCallback;)V", "GetSetTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_Handler")]
		public virtual unsafe void SetTransportCallback (global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback p0)
		{
			if (id_setTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_ == IntPtr.Zero)
				id_setTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_ = JNIEnv.GetMethodID (class_ref, "setTransportCallback", "(Lcom/alipay/android/phone/mrpc/core/TransportCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTransportCallback_Lcom_alipay_android_phone_mrpc_core_TransportCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTransportCallback", "(Lcom/alipay/android/phone/mrpc/core/TransportCallback;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/Request", DoNotGenerateAcw=true)]
	internal partial class RequestInvoker : Request {

		public RequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestInvoker); }
		}

	}

}
