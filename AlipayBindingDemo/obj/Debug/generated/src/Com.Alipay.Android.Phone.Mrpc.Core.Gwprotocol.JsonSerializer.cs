using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='JsonSerializer']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/gwprotocol/JsonSerializer", DoNotGenerateAcw=true)]
	public partial class JsonSerializer : global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.AbstractSerializer {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='JsonSerializer']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "1.0.0";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/gwprotocol/JsonSerializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonSerializer); }
		}

		protected JsonSerializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='JsonSerializer']/constructor[@name='JsonSerializer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe JsonSerializer (int p0, string p1, global::Java.Lang.Object p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (JsonSerializer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;Ljava/lang/Object;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/lang/String;Ljava/lang/Object;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/lang/Object;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_lang_Object_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.JsonSerializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.JsonSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static Delegate cb_setId_I;
#pragma warning disable 0169
		static Delegate GetSetId_IHandler ()
		{
			if (cb_setId_I == null)
				cb_setId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetId_I);
			return cb_setId_I;
		}

		static void n_SetId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.JsonSerializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.JsonSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_I;
		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='JsonSerializer']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='JsonSerializer']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setId", "(I)V", "GetSetId_IHandler")]
			set {
				if (id_setId_I == IntPtr.Zero)
					id_setId_I = JNIEnv.GetMethodID (class_ref, "setId", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setId_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.JsonSerializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.JsonSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Packet ());
		}
#pragma warning restore 0169

		static IntPtr id_packet;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='JsonSerializer']/method[@name='packet' and count(parameter)=0]"
		[Register ("packet", "()[B", "GetPacketHandler")]
		public override unsafe byte[] Packet ()
		{
			if (id_packet == IntPtr.Zero)
				id_packet = JNIEnv.GetMethodID (class_ref, "packet", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_packet), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "packet", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

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
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.JsonSerializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.JsonSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExtParam (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setExtParam_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='JsonSerializer']/method[@name='setExtParam' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setExtParam", "(Ljava/lang/Object;)V", "GetSetExtParam_Ljava_lang_Object_Handler")]
		public override unsafe void SetExtParam (global::Java.Lang.Object p0)
		{
			if (id_setExtParam_Ljava_lang_Object_ == IntPtr.Zero)
				id_setExtParam_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setExtParam", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtParam_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtParam", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

	}
}
