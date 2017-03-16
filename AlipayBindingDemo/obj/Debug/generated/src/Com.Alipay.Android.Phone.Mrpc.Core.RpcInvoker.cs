using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvoker']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/RpcInvoker", DoNotGenerateAcw=true)]
	public partial class RpcInvoker : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/RpcInvoker", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RpcInvoker); }
		}

		protected RpcInvoker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_alipay_android_phone_mrpc_core_RpcFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvoker']/constructor[@name='RpcInvoker' and count(parameter)=1 and parameter[1][@type='com.alipay.android.phone.mrpc.core.RpcFactory']]"
		[Register (".ctor", "(Lcom/alipay/android/phone/mrpc/core/RpcFactory;)V", "")]
		public unsafe RpcInvoker (global::Com.Alipay.Android.Phone.Mrpc.Core.RpcFactory p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (RpcInvoker)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/alipay/android/phone/mrpc/core/RpcFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/alipay/android/phone/mrpc/core/RpcFactory;)V", __args);
					return;
				}

				if (id_ctor_Lcom_alipay_android_phone_mrpc_core_RpcFactory_ == IntPtr.Zero)
					id_ctor_Lcom_alipay_android_phone_mrpc_core_RpcFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/alipay/android/phone/mrpc/core/RpcFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_alipay_android_phone_mrpc_core_RpcFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_alipay_android_phone_mrpc_core_RpcFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_addProtocolArgs_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvoker']/method[@name='addProtocolArgs' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("addProtocolArgs", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void AddProtocolArgs (string p0, global::Java.Lang.Object p1)
		{
			if (id_addProtocolArgs_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_addProtocolArgs_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "addProtocolArgs", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addProtocolArgs_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_batchBegin;
#pragma warning disable 0169
		static Delegate GetBatchBeginHandler ()
		{
			if (cb_batchBegin == null)
				cb_batchBegin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BatchBegin);
			return cb_batchBegin;
		}

		static void n_BatchBegin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BatchBegin ();
		}
#pragma warning restore 0169

		static IntPtr id_batchBegin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvoker']/method[@name='batchBegin' and count(parameter)=0]"
		[Register ("batchBegin", "()V", "GetBatchBeginHandler")]
		public virtual unsafe void BatchBegin ()
		{
			if (id_batchBegin == IntPtr.Zero)
				id_batchBegin = JNIEnv.GetMethodID (class_ref, "batchBegin", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_batchBegin);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "batchBegin", "()V"));
			} finally {
			}
		}

		static Delegate cb_batchCommit;
#pragma warning disable 0169
		static Delegate GetBatchCommitHandler ()
		{
			if (cb_batchCommit == null)
				cb_batchCommit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BatchCommit);
			return cb_batchCommit;
		}

		static IntPtr n_BatchCommit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BatchCommit ());
		}
#pragma warning restore 0169

		static IntPtr id_batchCommit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvoker']/method[@name='batchCommit' and count(parameter)=0]"
		[Register ("batchCommit", "()Ljava/util/concurrent/FutureTask;", "GetBatchCommitHandler")]
		public virtual unsafe global::Java.Util.Concurrent.FutureTask BatchCommit ()
		{
			if (id_batchCommit == IntPtr.Zero)
				id_batchCommit = JNIEnv.GetMethodID (class_ref, "batchCommit", "()Ljava/util/concurrent/FutureTask;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.FutureTask> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_batchCommit), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.FutureTask> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "batchCommit", "()Ljava/util/concurrent/FutureTask;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDeserializer_Ljava_lang_reflect_Type_arrayB;
#pragma warning disable 0169
		static Delegate GetGetDeserializer_Ljava_lang_reflect_Type_arrayBHandler ()
		{
			if (cb_getDeserializer_Ljava_lang_reflect_Type_arrayB == null)
				cb_getDeserializer_Ljava_lang_reflect_Type_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDeserializer_Ljava_lang_reflect_Type_arrayB);
			return cb_getDeserializer_Ljava_lang_reflect_Type_arrayB;
		}

		static IntPtr n_GetDeserializer_Ljava_lang_reflect_Type_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType p0 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDeserializer (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDeserializer_Ljava_lang_reflect_Type_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvoker']/method[@name='getDeserializer' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='byte[]']]"
		[Register ("getDeserializer", "(Ljava/lang/reflect/Type;[B)Lcom/alipay/android/phone/mrpc/core/gwprotocol/Deserializer;", "GetGetDeserializer_Ljava_lang_reflect_Type_arrayBHandler")]
		public virtual unsafe global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.IDeserializer GetDeserializer (global::Java.Lang.Reflect.IType p0, byte[] p1)
		{
			if (id_getDeserializer_Ljava_lang_reflect_Type_arrayB == IntPtr.Zero)
				id_getDeserializer_Ljava_lang_reflect_Type_arrayB = JNIEnv.GetMethodID (class_ref, "getDeserializer", "(Ljava/lang/reflect/Type;[B)Lcom/alipay/android/phone/mrpc/core/gwprotocol/Deserializer;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.IDeserializer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.IDeserializer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeserializer_Ljava_lang_reflect_Type_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.IDeserializer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeserializer", "(Ljava/lang/reflect/Type;[B)Lcom/alipay/android/phone/mrpc/core/gwprotocol/Deserializer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_getSerializer_ILjava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetSerializer_ILjava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_getSerializer_ILjava_lang_String_arrayLjava_lang_Object_ == null)
				cb_getSerializer_ILjava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetSerializer_ILjava_lang_String_arrayLjava_lang_Object_);
			return cb_getSerializer_ILjava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_GetSerializer_ILjava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSerializer (p0, p1, p2));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSerializer_ILjava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvoker']/method[@name='getSerializer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object[]']]"
		[Register ("getSerializer", "(ILjava/lang/String;[Ljava/lang/Object;)Lcom/alipay/android/phone/mrpc/core/gwprotocol/Serializer;", "GetGetSerializer_ILjava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializer GetSerializer (int p0, string p1, global::Java.Lang.Object[] p2)
		{
			if (id_getSerializer_ILjava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_getSerializer_ILjava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getSerializer", "(ILjava/lang/String;[Ljava/lang/Object;)Lcom/alipay/android/phone/mrpc/core/gwprotocol/Serializer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerializer_ILjava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSerializer", "(ILjava/lang/String;[Ljava/lang/Object;)Lcom/alipay/android/phone/mrpc/core/gwprotocol/Serializer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ;
#pragma warning disable 0169
		static Delegate GetGetTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZHandler ()
		{
			if (cb_getTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ == null)
				cb_getTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, bool, IntPtr>) n_GetTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ);
			return cb_getTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ;
		}

		static IntPtr n_GetTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, bool p4)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.Method p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTransport (p0, p1, p2, p3, p4));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvoker']/method[@name='getTransport' and count(parameter)=5 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='boolean']]"
		[Register ("getTransport", "(Ljava/lang/reflect/Method;ILjava/lang/String;[BZ)Lcom/alipay/android/phone/mrpc/core/RpcCaller;", "GetGetTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZHandler")]
		public virtual unsafe global::Com.Alipay.Android.Phone.Mrpc.Core.IRpcCaller GetTransport (global::Java.Lang.Reflect.Method p0, int p1, string p2, byte[] p3, bool p4)
		{
			if (id_getTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ == IntPtr.Zero)
				id_getTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ = JNIEnv.GetMethodID (class_ref, "getTransport", "(Ljava/lang/reflect/Method;ILjava/lang/String;[BZ)Lcom/alipay/android/phone/mrpc/core/RpcCaller;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (p4);

				global::Com.Alipay.Android.Phone.Mrpc.Core.IRpcCaller __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IRpcCaller> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransport_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IRpcCaller> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTransport", "(Ljava/lang/reflect/Method;ILjava/lang/String;[BZ)Lcom/alipay/android/phone/mrpc/core/RpcCaller;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler ()
		{
			if (cb_invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == null)
				cb_invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_);
			return cb_invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		}

		static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcInvoker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.Method p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (p0, p1, p2, p3));
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcInvoker']/method[@name='invoke' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Class&lt;?&gt;'] and parameter[3][@type='java.lang.reflect.Method'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("invoke", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object Invoke (global::Java.Lang.Object p0, global::Java.Lang.Class p1, global::Java.Lang.Reflect.Method p2, global::Java.Lang.Object[] p3)
		{
			if (id_invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_Object_Ljava_lang_Class_Ljava_lang_reflect_Method_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invoke", "(Ljava/lang/Object;Ljava/lang/Class;Ljava/lang/reflect/Method;[Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

	}
}
