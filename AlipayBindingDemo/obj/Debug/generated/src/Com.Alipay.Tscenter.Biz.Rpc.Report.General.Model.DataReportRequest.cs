using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportRequest']"
	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/report/general/model/DataReportRequest", DoNotGenerateAcw=true)]
	public partial class DataReportRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr bizData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportRequest']/field[@name='bizData']"
		[Register ("bizData")]
		public global::System.Collections.IDictionary BizData {
			get {
				if (bizData_jfieldId == IntPtr.Zero)
					bizData_jfieldId = JNIEnv.GetFieldID (class_ref, "bizData", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bizData_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bizData_jfieldId == IntPtr.Zero)
					bizData_jfieldId = JNIEnv.GetFieldID (class_ref, "bizData", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bizData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr bizType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportRequest']/field[@name='bizType']"
		[Register ("bizType")]
		public string BizType {
			get {
				if (bizType_jfieldId == IntPtr.Zero)
					bizType_jfieldId = JNIEnv.GetFieldID (class_ref, "bizType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bizType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bizType_jfieldId == IntPtr.Zero)
					bizType_jfieldId = JNIEnv.GetFieldID (class_ref, "bizType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bizType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr deviceData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportRequest']/field[@name='deviceData']"
		[Register ("deviceData")]
		public global::System.Collections.IDictionary DeviceData {
			get {
				if (deviceData_jfieldId == IntPtr.Zero)
					deviceData_jfieldId = JNIEnv.GetFieldID (class_ref, "deviceData", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, deviceData_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (deviceData_jfieldId == IntPtr.Zero)
					deviceData_jfieldId = JNIEnv.GetFieldID (class_ref, "deviceData", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, deviceData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr os_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportRequest']/field[@name='os']"
		[Register ("os")]
		public string Os {
			get {
				if (os_jfieldId == IntPtr.Zero)
					os_jfieldId = JNIEnv.GetFieldID (class_ref, "os", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, os_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (os_jfieldId == IntPtr.Zero)
					os_jfieldId = JNIEnv.GetFieldID (class_ref, "os", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, os_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr rpcVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportRequest']/field[@name='rpcVersion']"
		[Register ("rpcVersion")]
		public string RpcVersion {
			get {
				if (rpcVersion_jfieldId == IntPtr.Zero)
					rpcVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "rpcVersion", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rpcVersion_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rpcVersion_jfieldId == IntPtr.Zero)
					rpcVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "rpcVersion", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rpcVersion_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/report/general/model/DataReportRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataReportRequest); }
		}

		protected DataReportRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general.model']/class[@name='DataReportRequest']/constructor[@name='DataReportRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DataReportRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DataReportRequest)) {
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
