using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IRemoteServiceCallback.Stub']"
	[global::Android.Runtime.Register ("com/alipay/android/app/IRemoteServiceCallback$Stub", DoNotGenerateAcw=true)]
	public abstract partial class RemoteServiceCallbackStub : global::Android.OS.Binder, global::Com.Alipay.Android.App.IRemoteServiceCallback {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/app/IRemoteServiceCallback$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RemoteServiceCallbackStub); }
		}

		protected RemoteServiceCallbackStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IRemoteServiceCallback.Stub']/constructor[@name='IRemoteServiceCallback.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RemoteServiceCallbackStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RemoteServiceCallbackStub)) {
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.App.RemoteServiceCallbackStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.RemoteServiceCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IRemoteServiceCallback.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asBinder", "()Landroid/os/IBinder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_asInterface_Landroid_os_IBinder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IRemoteServiceCallback.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/alipay/android/app/IRemoteServiceCallback;", "")]
		public static unsafe global::Com.Alipay.Android.App.IRemoteServiceCallback AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/alipay/android/app/IRemoteServiceCallback;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Alipay.Android.App.IRemoteServiceCallback __ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IRemoteServiceCallback> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Com.Alipay.Android.App.RemoteServiceCallbackStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.RemoteServiceCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IRemoteServiceCallback.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int p0, global::Android.OS.Parcel p1, global::Android.OS.Parcel p2, int p3)
		{
			if (id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_payEnd_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPayEnd_ZLjava_lang_String_Handler ()
		{
			if (cb_payEnd_ZLjava_lang_String_ == null)
				cb_payEnd_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_PayEnd_ZLjava_lang_String_);
			return cb_payEnd_ZLjava_lang_String_;
		}

		static void n_PayEnd_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Alipay.Android.App.RemoteServiceCallbackStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.RemoteServiceCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PayEnd (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IRemoteServiceCallback']/method[@name='payEnd' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("payEnd", "(ZLjava/lang/String;)V", "GetPayEnd_ZLjava_lang_String_Handler")]
		public abstract void PayEnd (bool p0, string p1);

		static Delegate cb_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_Handler ()
		{
			if (cb_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ == null)
				cb_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_StartActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_);
			return cb_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_;
		}

		static void n_StartActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Com.Alipay.Android.App.RemoteServiceCallbackStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.RemoteServiceCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.StartActivity (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IRemoteServiceCallback']/method[@name='startActivity' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("startActivity", "(Ljava/lang/String;Ljava/lang/String;ILandroid/os/Bundle;)V", "GetStartActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_Handler")]
		public abstract void StartActivity (string p0, string p1, int p2, global::Android.OS.Bundle p3);

		static Delegate cb_isHideLoadingScreen;
#pragma warning disable 0169
		static Delegate GetIsHideLoadingScreenHandler ()
		{
			if (cb_isHideLoadingScreen == null)
				cb_isHideLoadingScreen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideLoadingScreen);
			return cb_isHideLoadingScreen;
		}

		static bool n_IsHideLoadingScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.App.RemoteServiceCallbackStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.RemoteServiceCallbackStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideLoadingScreen;
		}
#pragma warning restore 0169

		public abstract bool IsHideLoadingScreen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IRemoteServiceCallback.Stub']/method[@name='isHideLoadingScreen' and count(parameter)=0]"
			[Register ("isHideLoadingScreen", "()Z", "GetIsHideLoadingScreenHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/alipay/android/app/IRemoteServiceCallback$Stub", DoNotGenerateAcw=true)]
	internal partial class RemoteServiceCallbackStubInvoker : RemoteServiceCallbackStub {

		public RemoteServiceCallbackStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RemoteServiceCallbackStubInvoker); }
		}

		static IntPtr id_isHideLoadingScreen;
		public override unsafe bool IsHideLoadingScreen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IRemoteServiceCallback.Stub']/method[@name='isHideLoadingScreen' and count(parameter)=0]"
			[Register ("isHideLoadingScreen", "()Z", "GetIsHideLoadingScreenHandler")]
			get {
				if (id_isHideLoadingScreen == IntPtr.Zero)
					id_isHideLoadingScreen = JNIEnv.GetMethodID (class_ref, "isHideLoadingScreen", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideLoadingScreen);
				} finally {
				}
			}
		}

		static IntPtr id_payEnd_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IRemoteServiceCallback']/method[@name='payEnd' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("payEnd", "(ZLjava/lang/String;)V", "GetPayEnd_ZLjava_lang_String_Handler")]
		public override unsafe void PayEnd (bool p0, string p1)
		{
			if (id_payEnd_ZLjava_lang_String_ == IntPtr.Zero)
				id_payEnd_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "payEnd", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_payEnd_ZLjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IRemoteServiceCallback']/method[@name='startActivity' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("startActivity", "(Ljava/lang/String;Ljava/lang/String;ILandroid/os/Bundle;)V", "GetStartActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_Handler")]
		public override unsafe void StartActivity (string p0, string p1, int p2, global::Android.OS.Bundle p3)
		{
			if (id_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "startActivity", "(Ljava/lang/String;Ljava/lang/String;ILandroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IRemoteServiceCallback']"
	[Register ("com/alipay/android/app/IRemoteServiceCallback", "", "Com.Alipay.Android.App.IRemoteServiceCallbackInvoker")]
	public partial interface IRemoteServiceCallback : global::Android.OS.IInterface {

		bool IsHideLoadingScreen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IRemoteServiceCallback']/method[@name='isHideLoadingScreen' and count(parameter)=0]"
			[Register ("isHideLoadingScreen", "()Z", "GetIsHideLoadingScreenHandler:Com.Alipay.Android.App.IRemoteServiceCallbackInvoker, AlipayBindingDemo")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IRemoteServiceCallback']/method[@name='payEnd' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("payEnd", "(ZLjava/lang/String;)V", "GetPayEnd_ZLjava_lang_String_Handler:Com.Alipay.Android.App.IRemoteServiceCallbackInvoker, AlipayBindingDemo")]
		void PayEnd (bool p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IRemoteServiceCallback']/method[@name='startActivity' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("startActivity", "(Ljava/lang/String;Ljava/lang/String;ILandroid/os/Bundle;)V", "GetStartActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_Handler:Com.Alipay.Android.App.IRemoteServiceCallbackInvoker, AlipayBindingDemo")]
		void StartActivity (string p0, string p1, int p2, global::Android.OS.Bundle p3);

	}

	[global::Android.Runtime.Register ("com/alipay/android/app/IRemoteServiceCallback", DoNotGenerateAcw=true)]
	internal class IRemoteServiceCallbackInvoker : global::Java.Lang.Object, IRemoteServiceCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/android/app/IRemoteServiceCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRemoteServiceCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IRemoteServiceCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoteServiceCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.android.app.IRemoteServiceCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoteServiceCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isHideLoadingScreen;
#pragma warning disable 0169
		static Delegate GetIsHideLoadingScreenHandler ()
		{
			if (cb_isHideLoadingScreen == null)
				cb_isHideLoadingScreen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideLoadingScreen);
			return cb_isHideLoadingScreen;
		}

		static bool n_IsHideLoadingScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.App.IRemoteServiceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IRemoteServiceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideLoadingScreen;
		}
#pragma warning restore 0169

		IntPtr id_isHideLoadingScreen;
		public unsafe bool IsHideLoadingScreen {
			get {
				if (id_isHideLoadingScreen == IntPtr.Zero)
					id_isHideLoadingScreen = JNIEnv.GetMethodID (class_ref, "isHideLoadingScreen", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideLoadingScreen);
			}
		}

		static Delegate cb_payEnd_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPayEnd_ZLjava_lang_String_Handler ()
		{
			if (cb_payEnd_ZLjava_lang_String_ == null)
				cb_payEnd_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_PayEnd_ZLjava_lang_String_);
			return cb_payEnd_ZLjava_lang_String_;
		}

		static void n_PayEnd_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Alipay.Android.App.IRemoteServiceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IRemoteServiceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PayEnd (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_payEnd_ZLjava_lang_String_;
		public unsafe void PayEnd (bool p0, string p1)
		{
			if (id_payEnd_ZLjava_lang_String_ == IntPtr.Zero)
				id_payEnd_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "payEnd", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_payEnd_ZLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_Handler ()
		{
			if (cb_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ == null)
				cb_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_StartActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_);
			return cb_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_;
		}

		static void n_StartActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::Com.Alipay.Android.App.IRemoteServiceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IRemoteServiceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.StartActivity (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_;
		public unsafe void StartActivity (string p0, string p1, int p2, global::Android.OS.Bundle p3)
		{
			if (id_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ == IntPtr.Zero)
				id_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "startActivity", "(Ljava/lang/String;Ljava/lang/String;ILandroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startActivity_Ljava_lang_String_Ljava_lang_String_ILandroid_os_Bundle_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.App.IRemoteServiceCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IRemoteServiceCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
