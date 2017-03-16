using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcClient']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/RpcClient", DoNotGenerateAcw=true)]
	public abstract partial class RpcClient : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/RpcClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RpcClient); }
		}

		protected RpcClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcClient']/constructor[@name='RpcClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RpcClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RpcClient)) {
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

		static Delegate cb_getRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_;
#pragma warning disable 0169
		static Delegate GetGetRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_Handler ()
		{
			if (cb_getRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_ == null)
				cb_getRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_);
			return cb_getRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_;
		}

		static IntPtr n_GetRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcClient __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams p1 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRpcProxy (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcClient']/method[@name='getRpcProxy' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='com.alipay.android.phone.mrpc.core.RpcParams']]"
		[Register ("getRpcProxy", "(Ljava/lang/Class;Lcom/alipay/android/phone/mrpc/core/RpcParams;)Ljava/lang/Object;", "GetGetRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public abstract global::Java.Lang.Object GetRpcProxy (global::Java.Lang.Class p0, global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams p1);

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/RpcClient", DoNotGenerateAcw=true)]
	internal partial class RpcClientInvoker : RpcClient {

		public RpcClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RpcClientInvoker); }
		}

		static IntPtr id_getRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcClient']/method[@name='getRpcProxy' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T&gt;'] and parameter[2][@type='com.alipay.android.phone.mrpc.core.RpcParams']]"
		[Register ("getRpcProxy", "(Ljava/lang/Class;Lcom/alipay/android/phone/mrpc/core/RpcParams;)Ljava/lang/Object;", "GetGetRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public override unsafe global::Java.Lang.Object GetRpcProxy (global::Java.Lang.Class p0, global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams p1)
		{
			if (id_getRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_ == IntPtr.Zero)
				id_getRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_ = JNIEnv.GetMethodID (class_ref, "getRpcProxy", "(Ljava/lang/Class;Lcom/alipay/android/phone/mrpc/core/RpcParams;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRpcProxy_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcParams_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
