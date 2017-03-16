using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='AppListResult']"
	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/vkeydfp/result/AppListResult", DoNotGenerateAcw=true)]
	public partial class AppListResult : global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.BaseResult, global::Java.IO.ISerializable {


		static IntPtr appListData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='AppListResult']/field[@name='appListData']"
		[Register ("appListData")]
		public string AppListData {
			get {
				if (appListData_jfieldId == IntPtr.Zero)
					appListData_jfieldId = JNIEnv.GetFieldID (class_ref, "appListData", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appListData_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appListData_jfieldId == IntPtr.Zero)
					appListData_jfieldId = JNIEnv.GetFieldID (class_ref, "appListData", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appListData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr appListVer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='AppListResult']/field[@name='appListVer']"
		[Register ("appListVer")]
		public string AppListVer {
			get {
				if (appListVer_jfieldId == IntPtr.Zero)
					appListVer_jfieldId = JNIEnv.GetFieldID (class_ref, "appListVer", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, appListVer_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appListVer_jfieldId == IntPtr.Zero)
					appListVer_jfieldId = JNIEnv.GetFieldID (class_ref, "appListVer", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, appListVer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/vkeydfp/result/AppListResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppListResult); }
		}

		protected AppListResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='AppListResult']/constructor[@name='AppListResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppListResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AppListResult)) {
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
