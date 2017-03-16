using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvocationHandler']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/RpcInvocationHandler", DoNotGenerateAcw=true)]
	public partial class RpcInvocationHandler : global::Java.Lang.Object, global::Java.Lang.Reflect.IInvocationHandler {


		static IntPtr mClazz_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvocationHandler']/field[@name='mClazz']"
		[Register ("mClazz")]
		protected global::Java.Lang.Class MClazz {
			get {
				if (mClazz_jfieldId == IntPtr.Zero)
					mClazz_jfieldId = JNIEnv.GetFieldID (class_ref, "mClazz", "Ljava/lang/Class;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mClazz_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mClazz_jfieldId == IntPtr.Zero)
					mClazz_jfieldId = JNIEnv.GetFieldID (class_ref, "mClazz", "Ljava/lang/Class;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mClazz_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mConfig_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvocationHandler']/field[@name='mConfig']"
		[Register ("mConfig")]
		protected global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig MConfig {
			get {
				if (mConfig_jfieldId == IntPtr.Zero)
					mConfig_jfieldId = JNIEnv.GetFieldID (class_ref, "mConfig", "Lcom/alipay/android/phone/mrpc/core/Config;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mConfig_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mConfig_jfieldId == IntPtr.Zero)
					mConfig_jfieldId = JNIEnv.GetFieldID (class_ref, "mConfig", "Lcom/alipay/android/phone/mrpc/core/Config;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mConfig_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRpcInvoker_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvocationHandler']/field[@name='mRpcInvoker']"
		[Register ("mRpcInvoker")]
		protected global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker MRpcInvoker {
			get {
				if (mRpcInvoker_jfieldId == IntPtr.Zero)
					mRpcInvoker_jfieldId = JNIEnv.GetFieldID (class_ref, "mRpcInvoker", "Lcom/alipay/android/phone/mrpc/core/RpcInvoker;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mRpcInvoker_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRpcInvoker_jfieldId == IntPtr.Zero)
					mRpcInvoker_jfieldId = JNIEnv.GetFieldID (class_ref, "mRpcInvoker", "Lcom/alipay/android/phone/mrpc/core/RpcInvoker;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mRpcInvoker_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/RpcInvocationHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RpcInvocationHandler); }
		}

		protected RpcInvocationHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcInvoker_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvocationHandler']/constructor[@name='RpcInvocationHandler' and count(parameter)=3 and parameter[1][@type='com.alipay.android.phone.mrpc.core.Config'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='com.alipay.android.phone.mrpc.core.RpcInvoker']]"
		[Register (".ctor", "(Lcom/alipay/android/phone/mrpc/core/Config;Ljava/lang/Class;Lcom/alipay/android/phone/mrpc/core/RpcInvoker;)V", "")]
		public unsafe RpcInvocationHandler (global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig p0, global::Java.Lang.Class p1, global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (RpcInvocationHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/alipay/android/phone/mrpc/core/Config;Ljava/lang/Class;Lcom/alipay/android/phone/mrpc/core/RpcInvoker;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/alipay/android/phone/mrpc/core/Config;Ljava/lang/Class;Lcom/alipay/android/phone/mrpc/core/RpcInvoker;)V", __args);
					return;
				}

				if (id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcInvoker_ == IntPtr.Zero)
					id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcInvoker_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/alipay/android/phone/mrpc/core/Config;Ljava/lang/Class;Lcom/alipay/android/phone/mrpc/core/RpcInvoker;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcInvoker_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_alipay_android_phone_mrpc_core_Config_Ljava_lang_Class_Lcom_alipay_android_phone_mrpc_core_RpcInvoker_, __args);
			} finally {
			}
		}

		static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler ()
		{
			if (cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
				cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_);
			return cb_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvocationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvocationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.Method p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvocationHandler']/method[@name='invoke' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Method'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Invoke (global::Java.Lang.Object p0, global::Java.Lang.Reflect.Method p1, global::Java.Lang.Object[] p2)
		{
			if (id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_Object_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invoke", "(Ljava/lang/Object;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
