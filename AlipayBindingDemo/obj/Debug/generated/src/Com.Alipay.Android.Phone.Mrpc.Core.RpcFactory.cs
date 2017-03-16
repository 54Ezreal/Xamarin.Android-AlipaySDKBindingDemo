using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcFactory']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/RpcFactory", DoNotGenerateAcw=true)]
	public partial class RpcFactory : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/RpcFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RpcFactory); }
		}

		protected RpcFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcFactory']/constructor[@name='RpcFactory' and count(parameter)=1 and parameter[1][@type='com.alipay.android.phone.mrpc.core.Config']]"
		[Register (".ctor", "(Lcom/alipay/android/phone/mrpc/core/Config;)V", "")]
		public unsafe RpcFactory (global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (RpcFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/alipay/android/phone/mrpc/core/Config;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/alipay/android/phone/mrpc/core/Config;)V", __args);
					return;
				}

				if (id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_ == IntPtr.Zero)
					id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/alipay/android/phone/mrpc/core/Config;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_, __args);
			} finally {
			}
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcFactory __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		static IntPtr id_getConfig;
		public virtual unsafe global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcFactory']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lcom/alipay/android/phone/mrpc/core/Config;", "GetGetConfigHandler")]
			get {
				if (id_getConfig == IntPtr.Zero)
					id_getConfig = JNIEnv.GetMethodID (class_ref, "getConfig", "()Lcom/alipay/android/phone/mrpc/core/Config;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfig", "()Lcom/alipay/android/phone/mrpc/core/Config;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRpcProxy_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetRpcProxy_Ljava_lang_Class_Handler ()
		{
			if (cb_getRpcProxy_Ljava_lang_Class_ == null)
				cb_getRpcProxy_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRpcProxy_Ljava_lang_Class_);
			return cb_getRpcProxy_Ljava_lang_Class_;
		}

		static IntPtr n_GetRpcProxy_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcFactory __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRpcProxy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRpcProxy_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcFactory']/method[@name='getRpcProxy' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getRpcProxy", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetGetRpcProxy_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Java.Lang.Object GetRpcProxy (global::Java.Lang.Class p0)
		{
			if (id_getRpcProxy_Ljava_lang_Class_ == IntPtr.Zero)
				id_getRpcProxy_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getRpcProxy", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRpcProxy_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRpcProxy", "(Ljava/lang/Class;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
