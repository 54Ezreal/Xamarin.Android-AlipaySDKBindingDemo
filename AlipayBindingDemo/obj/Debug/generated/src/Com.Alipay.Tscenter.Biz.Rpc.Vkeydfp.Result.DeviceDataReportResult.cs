using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='DeviceDataReportResult']"
	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/vkeydfp/result/DeviceDataReportResult", DoNotGenerateAcw=true)]
	public partial class DeviceDataReportResult : global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.BaseResult, global::Java.IO.ISerializable {


		static IntPtr apdid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='DeviceDataReportResult']/field[@name='apdid']"
		[Register ("apdid")]
		public string Apdid {
			get {
				if (apdid_jfieldId == IntPtr.Zero)
					apdid_jfieldId = JNIEnv.GetFieldID (class_ref, "apdid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, apdid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (apdid_jfieldId == IntPtr.Zero)
					apdid_jfieldId = JNIEnv.GetFieldID (class_ref, "apdid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, apdid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr appListVer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='DeviceDataReportResult']/field[@name='appListVer']"
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

		static IntPtr bugTrackSwitch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='DeviceDataReportResult']/field[@name='bugTrackSwitch']"
		[Register ("bugTrackSwitch")]
		public string BugTrackSwitch {
			get {
				if (bugTrackSwitch_jfieldId == IntPtr.Zero)
					bugTrackSwitch_jfieldId = JNIEnv.GetFieldID (class_ref, "bugTrackSwitch", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bugTrackSwitch_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bugTrackSwitch_jfieldId == IntPtr.Zero)
					bugTrackSwitch_jfieldId = JNIEnv.GetFieldID (class_ref, "bugTrackSwitch", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bugTrackSwitch_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr currentTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='DeviceDataReportResult']/field[@name='currentTime']"
		[Register ("currentTime")]
		public string CurrentTime {
			get {
				if (currentTime_jfieldId == IntPtr.Zero)
					currentTime_jfieldId = JNIEnv.GetFieldID (class_ref, "currentTime", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, currentTime_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (currentTime_jfieldId == IntPtr.Zero)
					currentTime_jfieldId = JNIEnv.GetFieldID (class_ref, "currentTime", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, currentTime_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr token_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='DeviceDataReportResult']/field[@name='token']"
		[Register ("token")]
		public string Token {
			get {
				if (token_jfieldId == IntPtr.Zero)
					token_jfieldId = JNIEnv.GetFieldID (class_ref, "token", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, token_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (token_jfieldId == IntPtr.Zero)
					token_jfieldId = JNIEnv.GetFieldID (class_ref, "token", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, token_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr version_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='DeviceDataReportResult']/field[@name='version']"
		[Register ("version")]
		public string Version {
			get {
				if (version_jfieldId == IntPtr.Zero)
					version_jfieldId = JNIEnv.GetFieldID (class_ref, "version", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, version_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (version_jfieldId == IntPtr.Zero)
					version_jfieldId = JNIEnv.GetFieldID (class_ref, "version", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, version_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr vkeySwitch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='DeviceDataReportResult']/field[@name='vkeySwitch']"
		[Register ("vkeySwitch")]
		public string VkeySwitch {
			get {
				if (vkeySwitch_jfieldId == IntPtr.Zero)
					vkeySwitch_jfieldId = JNIEnv.GetFieldID (class_ref, "vkeySwitch", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, vkeySwitch_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (vkeySwitch_jfieldId == IntPtr.Zero)
					vkeySwitch_jfieldId = JNIEnv.GetFieldID (class_ref, "vkeySwitch", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, vkeySwitch_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/vkeydfp/result/DeviceDataReportResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceDataReportResult); }
		}

		protected DeviceDataReportResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='DeviceDataReportResult']/constructor[@name='DeviceDataReportResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceDataReportResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DeviceDataReportResult)) {
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
