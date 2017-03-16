using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Serializer']"
	[Register ("com/alipay/android/phone/mrpc/core/gwprotocol/Serializer", "", "Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializerInvoker")]
	public partial interface ISerializer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Serializer']/method[@name='packet' and count(parameter)=0]"
		[Register ("packet", "()[B", "GetPacketHandler:Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializerInvoker, AlipayBindingDemo")]
		byte[] Packet ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Serializer']/method[@name='setExtParam' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setExtParam", "(Ljava/lang/Object;)V", "GetSetExtParam_Ljava_lang_Object_Handler:Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializerInvoker, AlipayBindingDemo")]
		void SetExtParam (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/gwprotocol/Serializer", DoNotGenerateAcw=true)]
	internal class ISerializerInvoker : global::Java.Lang.Object, ISerializer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/gwprotocol/Serializer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISerializerInvoker); }
		}

		IntPtr class_ref;

		public static ISerializer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISerializer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.android.phone.mrpc.core.gwprotocol.Serializer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISerializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Packet ());
		}
#pragma warning restore 0169

		IntPtr id_packet;
		public unsafe byte[] Packet ()
		{
			if (id_packet == IntPtr.Zero)
				id_packet = JNIEnv.GetMethodID (class_ref, "packet", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_packet), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.ISerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExtParam (p0);
		}
#pragma warning restore 0169

		IntPtr id_setExtParam_Ljava_lang_Object_;
		public unsafe void SetExtParam (global::Java.Lang.Object p0)
		{
			if (id_setExtParam_Ljava_lang_Object_ == IntPtr.Zero)
				id_setExtParam_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setExtParam", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtParam_Ljava_lang_Object_, __args);
		}

	}

}
