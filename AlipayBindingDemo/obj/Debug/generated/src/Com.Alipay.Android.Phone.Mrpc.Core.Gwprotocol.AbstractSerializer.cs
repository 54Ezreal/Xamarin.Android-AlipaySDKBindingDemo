using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='AbstractSerializer']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/gwprotocol/AbstractSerializer", DoNotGenerateAcw=true)]
	public abstract partial class AbstractSerializer : global::Java.Lang.Object, global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializer {


		static IntPtr mOperationType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='AbstractSerializer']/field[@name='mOperationType']"
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

		static IntPtr mParams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='AbstractSerializer']/field[@name='mParams']"
		[Register ("mParams")]
		protected global::Java.Lang.Object MParams {
			get {
				if (mParams_jfieldId == IntPtr.Zero)
					mParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mParams", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mParams_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mParams_jfieldId == IntPtr.Zero)
					mParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mParams", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mParams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/gwprotocol/AbstractSerializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractSerializer); }
		}

		protected AbstractSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='AbstractSerializer']/constructor[@name='AbstractSerializer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe AbstractSerializer (string p0, global::Java.Lang.Object p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AbstractSerializer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_packet;
#pragma warning disable 0169
		static Delegate GetPacketHandler ()
		{
			if (cb_packet == null)
				cb_packet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Packet);
			return cb_packet;
		}

		static IntPtr n_Packet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.AbstractSerializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.AbstractSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Packet ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Serializer']/method[@name='packet' and count(parameter)=0]"
		[Register ("packet", "()[B", "GetPacketHandler")]
		public abstract byte[] Packet ();

		static Delegate cb_setExtParam_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetExtParam_Ljava_lang_Object_Handler ()
		{
			if (cb_setExtParam_Ljava_lang_Object_ == null)
				cb_setExtParam_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtParam_Ljava_lang_Object_);
			return cb_setExtParam_Ljava_lang_Object_;
		}

		static void n_SetExtParam_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.AbstractSerializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.AbstractSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExtParam (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Serializer']/method[@name='setExtParam' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setExtParam", "(Ljava/lang/Object;)V", "GetSetExtParam_Ljava_lang_Object_Handler")]
		public abstract void SetExtParam (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/gwprotocol/AbstractSerializer", DoNotGenerateAcw=true)]
	internal partial class AbstractSerializerInvoker : AbstractSerializer {

		public AbstractSerializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractSerializerInvoker); }
		}

		static IntPtr id_packet;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Serializer']/method[@name='packet' and count(parameter)=0]"
		[Register ("packet", "()[B", "GetPacketHandler")]
		public override unsafe byte[] Packet ()
		{
			if (id_packet == IntPtr.Zero)
				id_packet = JNIEnv.GetMethodID (class_ref, "packet", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_packet), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_setExtParam_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Serializer']/method[@name='setExtParam' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setExtParam", "(Ljava/lang/Object;)V", "GetSetExtParam_Ljava_lang_Object_Handler")]
		public override unsafe void SetExtParam (global::Java.Lang.Object p0)
		{
			if (id_setExtParam_Ljava_lang_Object_ == IntPtr.Zero)
				id_setExtParam_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setExtParam", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtParam_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}

}
