using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='AppListCmdRequest']"
	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/vkeydfp/request/AppListCmdRequest", DoNotGenerateAcw=true)]
	public partial class AppListCmdRequest : global::Java.Lang.Object, global::Java.IO.ISerializable {


		static IntPtr apdid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='AppListCmdRequest']/field[@name='apdid']"
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

		static IntPtr applist_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='AppListCmdRequest']/field[@name='applist']"
		[Register ("applist")]
		public string Applist {
			get {
				if (applist_jfieldId == IntPtr.Zero)
					applist_jfieldId = JNIEnv.GetFieldID (class_ref, "applist", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, applist_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (applist_jfieldId == IntPtr.Zero)
					applist_jfieldId = JNIEnv.GetFieldID (class_ref, "applist", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, applist_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr os_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='AppListCmdRequest']/field[@name='os']"
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

		static IntPtr token_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='AppListCmdRequest']/field[@name='token']"
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

		static IntPtr userId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='AppListCmdRequest']/field[@name='userId']"
		[Register ("userId")]
		public string UserId {
			get {
				if (userId_jfieldId == IntPtr.Zero)
					userId_jfieldId = JNIEnv.GetFieldID (class_ref, "userId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, userId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (userId_jfieldId == IntPtr.Zero)
					userId_jfieldId = JNIEnv.GetFieldID (class_ref, "userId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, userId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/vkeydfp/request/AppListCmdRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppListCmdRequest); }
		}

		protected AppListCmdRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp.request']/class[@name='AppListCmdRequest']/constructor[@name='AppListCmdRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppListCmdRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AppListCmdRequest)) {
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
