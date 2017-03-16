using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/StringUtils", DoNotGenerateAcw=true)]
	public partial class StringUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/StringUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StringUtils); }
		}

		protected StringUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']/constructor[@name='StringUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe StringUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (StringUtils)) {
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

		static IntPtr id_convertObjectToString_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']/method[@name='convertObjectToString' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string ConvertObjectToString (global::Java.Lang.Object p0)
		{
			if (id_convertObjectToString_Ljava_lang_Object_ == IntPtr.Zero)
				id_convertObjectToString_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertObjectToString_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hashCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hashCode", "(Ljava/lang/String;)I", "")]
		public static unsafe int HashCode (string p0)
		{
			if (id_hashCode_Ljava_lang_String_ == IntPtr.Zero)
				id_hashCode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "hashCode", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_hashCode_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='StringUtils']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmpty", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsEmpty (string p0)
		{
			if (id_isEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_isEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isEmpty", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmpty_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
