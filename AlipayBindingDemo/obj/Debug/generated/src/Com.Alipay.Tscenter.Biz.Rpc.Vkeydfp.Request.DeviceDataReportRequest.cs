using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']"
	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/vkeydfp/request/DeviceDataReportRequest", DoNotGenerateAcw=true)]
	public partial class DeviceDataReportRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr apdid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/field[@name='apdid']"
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

		static IntPtr dataMap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/field[@name='dataMap']"
		[Register ("dataMap")]
		public global::System.Collections.IDictionary DataMap {
			get {
				if (dataMap_jfieldId == IntPtr.Zero)
					dataMap_jfieldId = JNIEnv.GetFieldID (class_ref, "dataMap", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, dataMap_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (dataMap_jfieldId == IntPtr.Zero)
					dataMap_jfieldId = JNIEnv.GetFieldID (class_ref, "dataMap", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dataMap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr lastTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/field[@name='lastTime']"
		[Register ("lastTime")]
		public string LastTime {
			get {
				if (lastTime_jfieldId == IntPtr.Zero)
					lastTime_jfieldId = JNIEnv.GetFieldID (class_ref, "lastTime", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, lastTime_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (lastTime_jfieldId == IntPtr.Zero)
					lastTime_jfieldId = JNIEnv.GetFieldID (class_ref, "lastTime", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastTime_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr os_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/field[@name='os']"
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

		static IntPtr priApdid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/field[@name='priApdid']"
		[Register ("priApdid")]
		public string PriApdid {
			get {
				if (priApdid_jfieldId == IntPtr.Zero)
					priApdid_jfieldId = JNIEnv.GetFieldID (class_ref, "priApdid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, priApdid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (priApdid_jfieldId == IntPtr.Zero)
					priApdid_jfieldId = JNIEnv.GetFieldID (class_ref, "priApdid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, priApdid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr pubApdid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/field[@name='pubApdid']"
		[Register ("pubApdid")]
		public string PubApdid {
			get {
				if (pubApdid_jfieldId == IntPtr.Zero)
					pubApdid_jfieldId = JNIEnv.GetFieldID (class_ref, "pubApdid", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, pubApdid_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pubApdid_jfieldId == IntPtr.Zero)
					pubApdid_jfieldId = JNIEnv.GetFieldID (class_ref, "pubApdid", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pubApdid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr token_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/field[@name='token']"
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

		static IntPtr umidToken_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/field[@name='umidToken']"
		[Register ("umidToken")]
		public string UmidToken {
			get {
				if (umidToken_jfieldId == IntPtr.Zero)
					umidToken_jfieldId = JNIEnv.GetFieldID (class_ref, "umidToken", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, umidToken_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (umidToken_jfieldId == IntPtr.Zero)
					umidToken_jfieldId = JNIEnv.GetFieldID (class_ref, "umidToken", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, umidToken_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr version_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/field[@name='version']"
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
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/vkeydfp/request/DeviceDataReportRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceDataReportRequest); }
		}

		protected DeviceDataReportRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='DeviceDataReportRequest']/constructor[@name='DeviceDataReportRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeviceDataReportRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DeviceDataReportRequest)) {
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
