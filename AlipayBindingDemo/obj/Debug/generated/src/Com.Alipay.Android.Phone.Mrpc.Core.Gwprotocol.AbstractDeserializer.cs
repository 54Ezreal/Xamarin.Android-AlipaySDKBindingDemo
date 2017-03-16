using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='AbstractDeserializer']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/gwprotocol/AbstractDeserializer", DoNotGenerateAcw=true)]
	public abstract partial class AbstractDeserializer : global::Java.Lang.Object, global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.IDeserializer {


		static IntPtr mData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='AbstractDeserializer']/field[@name='mData']"
		[Register ("mData")]
		protected IList<byte> MData {
			get {
				if (mData_jfieldId == IntPtr.Zero)
					mData_jfieldId = JNIEnv.GetFieldID (class_ref, "mData", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mData_jfieldId == IntPtr.Zero)
					mData_jfieldId = JNIEnv.GetFieldID (class_ref, "mData", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='AbstractDeserializer']/field[@name='mType']"
		[Register ("mType")]
		protected global::Java.Lang.Reflect.IType MType {
			get {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Ljava/lang/reflect/Type;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Ljava/lang/reflect/Type;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/gwprotocol/AbstractDeserializer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDeserializer); }
		}

		protected AbstractDeserializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_reflect_Type_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/class[@name='AbstractDeserializer']/constructor[@name='AbstractDeserializer' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/reflect/Type;[B)V", "")]
		public unsafe AbstractDeserializer (global::Java.Lang.Reflect.IType p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (AbstractDeserializer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/reflect/Type;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/reflect/Type;[B)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_reflect_Type_arrayB == IntPtr.Zero)
					id_ctor_Ljava_lang_reflect_Type_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/reflect/Type;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_reflect_Type_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_reflect_Type_arrayB, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
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
			global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.AbstractDeserializer __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Gwprotocol.AbstractDeserializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parser ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Deserializer']/method[@name='parser' and count(parameter)=0]"
		[Register ("parser", "()Ljava/lang/Object;", "GetParserHandler")]
		public abstract global::Java.Lang.Object Parser ();

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/gwprotocol/AbstractDeserializer", DoNotGenerateAcw=true)]
	internal partial class AbstractDeserializerInvoker : AbstractDeserializer {

		public AbstractDeserializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractDeserializerInvoker); }
		}

		static IntPtr id_parser;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core.gwprotocol']/interface[@name='Deserializer']/method[@name='parser' and count(parameter)=0]"
		[Register ("parser", "()Ljava/lang/Object;", "GetParserHandler")]
		public override unsafe global::Java.Lang.Object Parser ()
		{
			if (id_parser == IntPtr.Zero)
				id_parser = JNIEnv.GetMethodID (class_ref, "parser", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parser), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
