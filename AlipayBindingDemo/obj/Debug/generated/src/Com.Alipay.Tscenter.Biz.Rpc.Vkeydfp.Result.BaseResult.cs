using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='BaseResult']"
	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/vkeydfp/result/BaseResult", DoNotGenerateAcw=true)]
	public partial class BaseResult : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr resultCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='BaseResult']/field[@name='resultCode']"
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

		static IntPtr success_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='BaseResult']/field[@name='success']"
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
				return JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/vkeydfp/result/BaseResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseResult); }
		}

		protected BaseResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.result']/class[@name='BaseResult']/constructor[@name='BaseResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BaseResult)) {
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
