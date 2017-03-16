using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='AbstractRpcCaller']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/AbstractRpcCaller", DoNotGenerateAcw=true)]
	public abstract partial class AbstractRpcCaller : global::Java.Lang.Object, global::Com.Alipay.Android.Phone.Mrpc.Core.IRpcCaller {


		static IntPtr mContentType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='AbstractRpcCaller']/field[@name='mContentType']"
		[Register ("mContentType")]
		protected string MContentType {
			get {
				if (mContentType_jfieldId == IntPtr.Zero)
					mContentType_jfieldId = JNIEnv.GetFieldID (class_ref, "mContentType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContentType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContentType_jfieldId == IntPtr.Zero)
					mContentType_jfieldId = JNIEnv.GetFieldID (class_ref, "mContentType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContentType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='AbstractRpcCaller']/field[@name='mId']"
		[Register ("mId")]
		protected int MId {
			get {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mId_jfieldId);
			}
			set {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mMethod_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='AbstractRpcCaller']/field[@name='mMethod']"
		[Register ("mMethod")]
		protected global::Java.Lang.Reflect.Method MMethod {
			get {
				if (mMethod_jfieldId == IntPtr.Zero)
					mMethod_jfieldId = JNIEnv.GetFieldID (class_ref, "mMethod", "Ljava/lang/reflect/Method;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMethod_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Method> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMethod_jfieldId == IntPtr.Zero)
					mMethod_jfieldId = JNIEnv.GetFieldID (class_ref, "mMethod", "Ljava/lang/reflect/Method;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMethod_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mOperationType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='AbstractRpcCaller']/field[@name='mOperationType']"
		[Register ("mOperationType")]
		protected string MOperationType {
			get {
				if (mOperationType_jfieldId == IntPtr.Zero)
					mOperationType_jfieldId = JNIEnv.GetFieldID (class_ref, "mOperationType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mOperationType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOperationType_jfieldId == IntPtr.Zero)
					mOperationType_jfieldId = JNIEnv.GetFieldID (class_ref, "mOperationType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOperationType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mReqData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='AbstractRpcCaller']/field[@name='mReqData']"
		[Register ("mReqData")]
		protected IList<byte> MReqData {
			get {
				if (mReqData_jfieldId == IntPtr.Zero)
					mReqData_jfieldId = JNIEnv.GetFieldID (class_ref, "mReqData", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mReqData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mReqData_jfieldId == IntPtr.Zero)
					mReqData_jfieldId = JNIEnv.GetFieldID (class_ref, "mReqData", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mReqData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mResetCookie_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='AbstractRpcCaller']/field[@name='mResetCookie']"
		[Register ("mResetCookie")]
		protected bool MResetCookie {
			get {
				if (mResetCookie_jfieldId == IntPtr.Zero)
					mResetCookie_jfieldId = JNIEnv.GetFieldID (class_ref, "mResetCookie", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, mResetCookie_jfieldId);
			}
			set {
				if (mResetCookie_jfieldId == IntPtr.Zero)
					mResetCookie_jfieldId = JNIEnv.GetFieldID (class_ref, "mResetCookie", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mResetCookie_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/AbstractRpcCaller", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractRpcCaller); }
		}

		protected AbstractRpcCaller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBLjava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='AbstractRpcCaller']/constructor[@name='AbstractRpcCaller' and count(parameter)=6 and parameter[1][@type='java.lang.reflect.Method'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/reflect/Method;ILjava/lang/String;[BLjava/lang/String;Z)V", "")]
		public unsafe AbstractRpcCaller (global::Java.Lang.Reflect.Method p0, int p1, string p2, byte[] p3, string p4, bool p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (AbstractRpcCaller)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/reflect/Method;ILjava/lang/String;[BLjava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/reflect/Method;ILjava/lang/String;[BLjava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBLjava_lang_String_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBLjava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/reflect/Method;ILjava/lang/String;[BLjava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBLjava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_reflect_Method_ILjava_lang_String_arrayBLjava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
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
			global::Com.Alipay.Android.Phone.Mrpc.Core.AbstractRpcCaller __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.AbstractRpcCaller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Call ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcCaller']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
		public abstract global::Java.Lang.Object Call ();

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/AbstractRpcCaller", DoNotGenerateAcw=true)]
	internal partial class AbstractRpcCallerInvoker : AbstractRpcCaller {

		public AbstractRpcCallerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractRpcCallerInvoker); }
		}

		static IntPtr id_call;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcCaller']/method[@name='call' and count(parameter)=0]"
		[Register ("call", "()Ljava/lang/Object;", "GetCallHandler")]
		public override unsafe global::Java.Lang.Object Call ()
		{
			if (id_call == IntPtr.Zero)
				id_call = JNIEnv.GetMethodID (class_ref, "call", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_call), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
