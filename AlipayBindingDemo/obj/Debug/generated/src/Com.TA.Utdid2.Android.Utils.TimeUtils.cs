using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='TimeUtils']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/TimeUtils", DoNotGenerateAcw=true)]
	public partial class TimeUtils : global::Java.Lang.Object {


		static IntPtr TAG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='TimeUtils']/field[@name='TAG']"
		[Register ("TAG")]
		public static string Tag {
			get {
				if (TAG_jfieldId == IntPtr.Zero)
					TAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='TimeUtils']/field[@name='TOTAL_M_S_ONE_DAY']"
		[Register ("TOTAL_M_S_ONE_DAY")]
		public const int TotalMSOneDay = (int) 86400000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/TimeUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeUtils); }
		}

		protected TimeUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='TimeUtils']/constructor[@name='TimeUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TimeUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TimeUtils)) {
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

		static IntPtr id_isUpToDate_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='TimeUtils']/method[@name='isUpToDate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("isUpToDate", "(JI)Z", "")]
		public static unsafe bool IsUpToDate (long p0, int p1)
		{
			if (id_isUpToDate_JI == IntPtr.Zero)
				id_isUpToDate_JI = JNIEnv.GetStaticMethodID (class_ref, "isUpToDate", "(JI)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isUpToDate_JI, __args);
			} finally {
			}
		}

	}
}
