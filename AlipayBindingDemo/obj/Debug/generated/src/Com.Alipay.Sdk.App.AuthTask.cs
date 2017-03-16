using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Sdk.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='AuthTask']"
	[global::Android.Runtime.Register ("com/alipay/sdk/app/AuthTask", DoNotGenerateAcw=true)]
	public partial class AuthTask : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/sdk/app/AuthTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AuthTask); }
		}

		protected AuthTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='AuthTask']/constructor[@name='AuthTask' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public unsafe AuthTask (global::Android.App.Activity p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AuthTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;)V", __args);
					return;
				}

				if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
					id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static Delegate cb_auth_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAuth_Ljava_lang_String_ZHandler ()
		{
			if (cb_auth_Ljava_lang_String_Z == null)
				cb_auth_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_Auth_Ljava_lang_String_Z);
			return cb_auth_Ljava_lang_String_Z;
		}

		static IntPtr n_Auth_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Alipay.Sdk.App.AuthTask __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.AuthTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Auth (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_auth_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='AuthTask']/method[@name='auth' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("auth", "(Ljava/lang/String;Z)Ljava/lang/String;", "GetAuth_Ljava_lang_String_ZHandler")]
		public virtual unsafe string Auth (string p0, bool p1)
		{
			if (id_auth_Ljava_lang_String_Z == IntPtr.Zero)
				id_auth_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "auth", "(Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_auth_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "auth", "(Ljava/lang/String;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_authV2_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetAuthV2_Ljava_lang_String_ZHandler ()
		{
			if (cb_authV2_Ljava_lang_String_Z == null)
				cb_authV2_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_AuthV2_Ljava_lang_String_Z);
			return cb_authV2_Ljava_lang_String_Z;
		}

		static IntPtr n_AuthV2_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Alipay.Sdk.App.AuthTask __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Sdk.App.AuthTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AuthV2 (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_authV2_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.sdk.app']/class[@name='AuthTask']/method[@name='authV2' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("authV2", "(Ljava/lang/String;Z)Ljava/util/Map;", "GetAuthV2_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> AuthV2 (string p0, bool p1)
		{
			if (id_authV2_Ljava_lang_String_Z == IntPtr.Zero)
				id_authV2_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "authV2", "(Ljava/lang/String;Z)Ljava/util/Map;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::System.Collections.Generic.IDictionary<string, string> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_authV2_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authV2", "(Ljava/lang/String;Z)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
