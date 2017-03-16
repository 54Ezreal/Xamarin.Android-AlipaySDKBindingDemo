using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='AppListCmdResult']"
	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/vkeydfp/result/AppListCmdResult", DoNotGenerateAcw=true)]
	public partial class AppListCmdResult : global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListResult, global::Java.IO.ISerializable {


		static IntPtr needRetry_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='AppListCmdResult']/field[@name='needRetry']"
		[Register ("needRetry")]
		public bool NeedRetry {
			get {
				if (needRetry_jfieldId == IntPtr.Zero)
					needRetry_jfieldId = JNIEnv.GetFieldID (class_ref, "needRetry", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, needRetry_jfieldId);
			}
			set {
				if (needRetry_jfieldId == IntPtr.Zero)
					needRetry_jfieldId = JNIEnv.GetFieldID (class_ref, "needRetry", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, needRetry_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/vkeydfp/result/AppListCmdResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppListCmdResult); }
		}

		protected AppListCmdResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='AppListCmdResult']/constructor[@name='AppListCmdResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppListCmdResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AppListCmdResult)) {
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
