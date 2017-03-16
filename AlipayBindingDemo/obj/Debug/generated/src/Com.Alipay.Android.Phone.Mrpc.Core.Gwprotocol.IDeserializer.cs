using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Deserializer']"
	[Register ("com/alipay/android/phone/mrpc/core/gwprotocol/Deserializer", "", "Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.IDeserializerInvoker")]
	public partial interface IDeserializer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Deserializer']/method[@name='parser' and count(parameter)=0]"
		[Register ("parser", "()Ljava/lang/Object;", "GetParserHandler:Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.IDeserializerInvoker, AlipayBindingDemo")]
		global::Java.Lang.Object Parser ();

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/gwprotocol/Deserializer", DoNotGenerateAcw=true)]
	internal class IDeserializerInvoker : global::Java.Lang.Object, IDeserializer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/gwprotocol/Deserializer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDeserializerInvoker); }
		}

		IntPtr class_ref;

		public static IDeserializer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeserializer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.android.phone.mrpc.core.gwprotocol.Deserializer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeserializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_parser;
#pragma warning disable 0169
		static Delegate GetParserHandler ()
		{
			if (cb_parser == null)
				cb_parser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Parser);
			return cb_parser;
		}

		static IntPtr n_Parser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.IDeserializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.IDeserializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parser ());
		}
#pragma warning restore 0169

		IntPtr id_parser;
		public unsafe global::Java.Lang.Object Parser ()
		{
			if (id_parser == IntPtr.Zero)
				id_parser = JNIEnv.GetMethodID (class_ref, "parser", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parser), JniHandleOwnership.TransferLocalRef);
		}

	}

}
