using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='Config']"
	[Register ("com/alipay/android/phone/mrpc/core/Config", "", "Com.Alipay.Android.Phone.Mrpc.Core.IConfigInvoker")]
	public partial interface IConfig : IJavaObject {

		global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='Config']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler:Com.Alipay.Android.Phone.Mrpc.Core.IConfigInvoker, AlipayBindingDemo")] get;
		}

		bool IsGzip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='Config']/method[@name='isGzip' and count(parameter)=0]"
			[Register ("isGzip", "()Z", "GetIsGzipHandler:Com.Alipay.Android.Phone.Mrpc.Core.IConfigInvoker, AlipayBindingDemo")] get;
		}

		global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams RpcParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='Config']/method[@name='getRpcParams' and count(parameter)=0]"
			[Register ("getRpcParams", "()Lcom/alipay/android/phone/mrpc/core/RpcParams;", "GetGetRpcParamsHandler:Com.Alipay.Android.Phone.Mrpc.Core.IConfigInvoker, AlipayBindingDemo")] get;
		}

		global::Com.Alipay.Android.Phone.Mrpc.Core.ITransport Transport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='Config']/method[@name='getTransport' and count(parameter)=0]"
			[Register ("getTransport", "()Lcom/alipay/android/phone/mrpc/core/Transport;", "GetGetTransportHandler:Com.Alipay.Android.Phone.Mrpc.Core.IConfigInvoker, AlipayBindingDemo")] get;
		}

		string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='Config']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler:Com.Alipay.Android.Phone.Mrpc.Core.IConfigInvoker, AlipayBindingDemo")] get;
		}

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/Config", DoNotGenerateAcw=true)]
	internal class IConfigInvoker : global::Java.Lang.Object, IConfig {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/Config");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IConfigInvoker); }
		}

		IntPtr class_ref;

		public static IConfig GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfig> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.android.phone.mrpc.core.Config"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getApplicationContext;
#pragma warning disable 0169
		static Delegate GetGetApplicationContextHandler ()
		{
			if (cb_getApplicationContext == null)
				cb_getApplicationContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationContext);
			return cb_getApplicationContext;
		}

		static IntPtr n_GetApplicationContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationContext);
		}
#pragma warning restore 0169

		IntPtr id_getApplicationContext;
		public unsafe global::Android.Content.Context ApplicationContext {
			get {
				if (id_getApplicationContext == IntPtr.Zero)
					id_getApplicationContext = JNIEnv.GetMethodID (class_ref, "getApplicationContext", "()Landroid/content/Context;");
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationContext), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isGzip;
#pragma warning disable 0169
		static Delegate GetIsGzipHandler ()
		{
			if (cb_isGzip == null)
				cb_isGzip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGzip);
			return cb_isGzip;
		}

		static bool n_IsGzip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGzip;
		}
#pragma warning restore 0169

		IntPtr id_isGzip;
		public unsafe bool IsGzip {
			get {
				if (id_isGzip == IntPtr.Zero)
					id_isGzip = JNIEnv.GetMethodID (class_ref, "isGzip", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isGzip);
			}
		}

		static Delegate cb_getRpcParams;
#pragma warning disable 0169
		static Delegate GetGetRpcParamsHandler ()
		{
			if (cb_getRpcParams == null)
				cb_getRpcParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRpcParams);
			return cb_getRpcParams;
		}

		static IntPtr n_GetRpcParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RpcParams);
		}
#pragma warning restore 0169

		IntPtr id_getRpcParams;
		public unsafe global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams RpcParams {
			get {
				if (id_getRpcParams == IntPtr.Zero)
					id_getRpcParams = JNIEnv.GetMethodID (class_ref, "getRpcParams", "()Lcom/alipay/android/phone/mrpc/core/RpcParams;");
				return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRpcParams), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTransport;
#pragma warning disable 0169
		static Delegate GetGetTransportHandler ()
		{
			if (cb_getTransport == null)
				cb_getTransport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransport);
			return cb_getTransport;
		}

		static IntPtr n_GetTransport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transport);
		}
#pragma warning restore 0169

		IntPtr id_getTransport;
		public unsafe global::Com.Alipay.Android.Phone.Mrpc.Core.ITransport Transport {
			get {
				if (id_getTransport == IntPtr.Zero)
					id_getTransport = JNIEnv.GetMethodID (class_ref, "getTransport", "()Lcom/alipay/android/phone/mrpc/core/Transport;");
				return global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransport> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransport), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		IntPtr id_getUrl;
		public unsafe string Url {
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
