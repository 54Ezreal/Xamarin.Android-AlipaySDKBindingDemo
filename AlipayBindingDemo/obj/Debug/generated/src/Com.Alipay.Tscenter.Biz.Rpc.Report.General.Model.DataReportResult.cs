using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportResult']"
	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/report/general/model/DataReportResult", DoNotGenerateAcw=true)]
	public partial class DataReportResult : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr resultCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportResult']/field[@name='resultCode']"
		[Register ("resultCode")]
		public string ResultCode {
			get {
				if (resultCode_jfieldId == IntPtr.Zero)
					resultCode_jfieldId = JNIEnv.GetFieldID (class_ref, "resultCode", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, resultCode_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (resultCode_jfieldId == IntPtr.Zero)
					resultCode_jfieldId = JNIEnv.GetFieldID (class_ref, "resultCode", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, resultCode_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr resultData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportResult']/field[@name='resultData']"
		[Register ("resultData")]
		public global::System.Collections.IDictionary ResultData {
			get {
				if (resultData_jfieldId == IntPtr.Zero)
					resultData_jfieldId = JNIEnv.GetFieldID (class_ref, "resultData", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, resultData_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (resultData_jfieldId == IntPtr.Zero)
					resultData_jfieldId = JNIEnv.GetFieldID (class_ref, "resultData", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, resultData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr success_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportResult']/field[@name='success']"
		[Register ("success")]
		public bool Success {
			get {
				if (success_jfieldId == IntPtr.Zero)
					success_jfieldId = JNIEnv.GetFieldID (class_ref, "success", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, success_jfieldId);
			}
			set {
				if (success_jfieldId == IntPtr.Zero)
					success_jfieldId = JNIEnv.GetFieldID (class_ref, "success", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, success_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/report/general/model/DataReportResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataReportResult); }
		}

		protected DataReportResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportResult']/constructor[@name='DataReportResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataReportResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DataReportResult)) {
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

	}
}
