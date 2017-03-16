using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.App {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IAlixPay.Stub']"
	[global::Android.Runtime.Register ("com/alipay/android/app/IAlixPay$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AlixPayStub : global::Android.OS.Binder, global::Com.Alipay.Android.App.IAlixPay {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/app/IAlixPay$Stub", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlixPayStub); }
		}

		protected AlixPayStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IAlixPay.Stub']/constructor[@name='IAlixPay.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlixPayStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AlixPayStub)) {
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
			global::Com.Alipay.Android.App.AlixPayStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.AlixPayStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		static IntPtr id_asBinder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IAlixPay.Stub']/method[@name='asBinder' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IAlixPay.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/alipay/android/app/IAlixPay;", "")]
		public static unsafe global::Com.Alipay.Android.App.IAlixPay AsInterface (global::Android.OS.IBinder p0)
		{
			if (id_asInterface_Landroid_os_IBinder_ == IntPtr.Zero)
				id_asInterface_Landroid_os_IBinder_ = JNIEnv.GetStaticMethodID (class_ref, "asInterface", "(Landroid/os/IBinder;)Lcom/alipay/android/app/IAlixPay;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Alipay.Android.App.IAlixPay __ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IAlixPay> (JNIEnv.CallStaticObjectMethod  (class_ref, id_asInterface_Landroid_os_IBinder_, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Alipay.Android.App.AlixPayStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.AlixPayStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/class[@name='IAlixPay.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_Pay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPay_Ljava_lang_String_Handler ()
		{
			if (cb_Pay_Ljava_lang_String_ == null)
				cb_Pay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Pay_Ljava_lang_String_);
			return cb_Pay_Ljava_lang_String_;
		}

		static IntPtr n_Pay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.App.AlixPayStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.AlixPayStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Pay (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='Pay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("Pay", "(Ljava/lang/String;)Ljava/lang/String;", "GetPay_Ljava_lang_String_Handler")]
		public abstract string Pay (string p0);

		static Delegate cb_prePay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrePay_Ljava_lang_String_Handler ()
		{
			if (cb_prePay_Ljava_lang_String_ == null)
				cb_prePay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrePay_Ljava_lang_String_);
			return cb_prePay_Ljava_lang_String_;
		}

		static IntPtr n_PrePay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.App.AlixPayStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.AlixPayStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PrePay (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='prePay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("prePay", "(Ljava/lang/String;)Ljava/lang/String;", "GetPrePay_Ljava_lang_String_Handler")]
		public abstract string PrePay (string p0);

		static Delegate cb_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
#pragma warning disable 0169
		static Delegate GetRegisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler ()
		{
			if (cb_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ == null)
				cb_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_);
			return cb_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
		}

		static void n_RegisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.App.AlixPayStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.AlixPayStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.App.IRemoteServiceCallback p0 = (global::Com.Alipay.Android.App.IRemoteServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IRemoteServiceCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='registerCallback' and count(parameter)=1 and parameter[1][@type='com.alipay.android.app.IRemoteServiceCallback']]"
		[Register ("registerCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V", "GetRegisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler")]
		public abstract void RegisterCallback (global::Com.Alipay.Android.App.IRemoteServiceCallback p0);

		static Delegate cb_test;
#pragma warning disable 0169
		static Delegate GetTestHandler ()
		{
			if (cb_test == null)
				cb_test = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Test);
			return cb_test;
		}

		static IntPtr n_Test (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.App.AlixPayStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.AlixPayStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Test ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='test' and count(parameter)=0]"
		[Register ("test", "()Ljava/lang/String;", "GetTestHandler")]
		public abstract string Test ();

		static Delegate cb_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
#pragma warning disable 0169
		static Delegate GetUnregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler ()
		{
			if (cb_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ == null)
				cb_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_);
			return cb_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
		}

		static void n_UnregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.App.AlixPayStub __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.AlixPayStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.App.IRemoteServiceCallback p0 = (global::Com.Alipay.Android.App.IRemoteServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IRemoteServiceCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='unregisterCallback' and count(parameter)=1 and parameter[1][@type='com.alipay.android.app.IRemoteServiceCallback']]"
		[Register ("unregisterCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V", "GetUnregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler")]
		public abstract void UnregisterCallback (global::Com.Alipay.Android.App.IRemoteServiceCallback p0);

	}

	[global::Android.Runtime.Register ("com/alipay/android/app/IAlixPay$Stub", DoNotGenerateAcw=true)]
	internal partial class AlixPayStubInvoker : AlixPayStub {

		public AlixPayStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlixPayStubInvoker); }
		}

		static IntPtr id_Pay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='Pay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("Pay", "(Ljava/lang/String;)Ljava/lang/String;", "GetPay_Ljava_lang_String_Handler")]
		public override unsafe string Pay (string p0)
		{
			if (id_Pay_Ljava_lang_String_ == IntPtr.Zero)
				id_Pay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Pay", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_Pay_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_prePay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='prePay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("prePay", "(Ljava/lang/String;)Ljava/lang/String;", "GetPrePay_Ljava_lang_String_Handler")]
		public override unsafe string PrePay (string p0)
		{
			if (id_prePay_Ljava_lang_String_ == IntPtr.Zero)
				id_prePay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "prePay", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prePay_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='registerCallback' and count(parameter)=1 and parameter[1][@type='com.alipay.android.app.IRemoteServiceCallback']]"
		[Register ("registerCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V", "GetRegisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler")]
		public override unsafe void RegisterCallback (global::Com.Alipay.Android.App.IRemoteServiceCallback p0)
		{
			if (id_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ == IntPtr.Zero)
				id_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ = JNIEnv.GetMethodID (class_ref, "registerCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_test;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='test' and count(parameter)=0]"
		[Register ("test", "()Ljava/lang/String;", "GetTestHandler")]
		public override unsafe string Test ()
		{
			if (id_test == IntPtr.Zero)
				id_test = JNIEnv.GetMethodID (class_ref, "test", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_test), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='unregisterCallback' and count(parameter)=1 and parameter[1][@type='com.alipay.android.app.IRemoteServiceCallback']]"
		[Register ("unregisterCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V", "GetUnregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler")]
		public override unsafe void UnregisterCallback (global::Com.Alipay.Android.App.IRemoteServiceCallback p0)
		{
			if (id_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ == IntPtr.Zero)
				id_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ = JNIEnv.GetMethodID (class_ref, "unregisterCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']"
	[Register ("com/alipay/android/app/IAlixPay", "", "Com.Alipay.Android.App.IAlixPayInvoker")]
	public partial interface IAlixPay : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='Pay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("Pay", "(Ljava/lang/String;)Ljava/lang/String;", "GetPay_Ljava_lang_String_Handler:Com.Alipay.Android.App.IAlixPayInvoker, AlipayBindingDemo")]
		string Pay (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='prePay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("prePay", "(Ljava/lang/String;)Ljava/lang/String;", "GetPrePay_Ljava_lang_String_Handler:Com.Alipay.Android.App.IAlixPayInvoker, AlipayBindingDemo")]
		string PrePay (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='registerCallback' and count(parameter)=1 and parameter[1][@type='com.alipay.android.app.IRemoteServiceCallback']]"
		[Register ("registerCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V", "GetRegisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler:Com.Alipay.Android.App.IAlixPayInvoker, AlipayBindingDemo")]
		void RegisterCallback (global::Com.Alipay.Android.App.IRemoteServiceCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='test' and count(parameter)=0]"
		[Register ("test", "()Ljava/lang/String;", "GetTestHandler:Com.Alipay.Android.App.IAlixPayInvoker, AlipayBindingDemo")]
		string Test ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.app']/interface[@name='IAlixPay']/method[@name='unregisterCallback' and count(parameter)=1 and parameter[1][@type='com.alipay.android.app.IRemoteServiceCallback']]"
		[Register ("unregisterCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V", "GetUnregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler:Com.Alipay.Android.App.IAlixPayInvoker, AlipayBindingDemo")]
		void UnregisterCallback (global::Com.Alipay.Android.App.IRemoteServiceCallback p0);

	}

	[global::Android.Runtime.Register ("com/alipay/android/app/IAlixPay", DoNotGenerateAcw=true)]
	internal class IAlixPayInvoker : global::Java.Lang.Object, IAlixPay {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/android/app/IAlixPay");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAlixPayInvoker); }
		}

		IntPtr class_ref;

		public static IAlixPay GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAlixPay> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.android.app.IAlixPay"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAlixPayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_Pay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPay_Ljava_lang_String_Handler ()
		{
			if (cb_Pay_Ljava_lang_String_ == null)
				cb_Pay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Pay_Ljava_lang_String_);
			return cb_Pay_Ljava_lang_String_;
		}

		static IntPtr n_Pay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.App.IAlixPay __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IAlixPay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Pay (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_Pay_Ljava_lang_String_;
		public unsafe string Pay (string p0)
		{
			if (id_Pay_Ljava_lang_String_ == IntPtr.Zero)
				id_Pay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "Pay", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_Pay_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_prePay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrePay_Ljava_lang_String_Handler ()
		{
			if (cb_prePay_Ljava_lang_String_ == null)
				cb_prePay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrePay_Ljava_lang_String_);
			return cb_prePay_Ljava_lang_String_;
		}

		static IntPtr n_PrePay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.App.IAlixPay __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IAlixPay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PrePay (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_prePay_Ljava_lang_String_;
		public unsafe string PrePay (string p0)
		{
			if (id_prePay_Ljava_lang_String_ == IntPtr.Zero)
				id_prePay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "prePay", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prePay_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
#pragma warning disable 0169
		static Delegate GetRegisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler ()
		{
			if (cb_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ == null)
				cb_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_);
			return cb_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
		}

		static void n_RegisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.App.IAlixPay __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IAlixPay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.App.IRemoteServiceCallback p0 = (global::Com.Alipay.Android.App.IRemoteServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IRemoteServiceCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
		public unsafe void RegisterCallback (global::Com.Alipay.Android.App.IRemoteServiceCallback p0)
		{
			if (id_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ == IntPtr.Zero)
				id_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ = JNIEnv.GetMethodID (class_ref, "registerCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerCallback_Lcom_alipay_android_app_IRemoteServiceCallback_, __args);
		}

		static Delegate cb_test;
#pragma warning disable 0169
		static Delegate GetTestHandler ()
		{
			if (cb_test == null)
				cb_test = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Test);
			return cb_test;
		}

		static IntPtr n_Test (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Android.App.IAlixPay __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IAlixPay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Test ());
		}
#pragma warning restore 0169

		IntPtr id_test;
		public unsafe string Test ()
		{
			if (id_test == IntPtr.Zero)
				id_test = JNIEnv.GetMethodID (class_ref, "test", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_test), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
#pragma warning disable 0169
		static Delegate GetUnregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_Handler ()
		{
			if (cb_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ == null)
				cb_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_);
			return cb_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
		}

		static void n_UnregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.App.IAlixPay __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IAlixPay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.App.IRemoteServiceCallback p0 = (global::Com.Alipay.Android.App.IRemoteServiceCallback)global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IRemoteServiceCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_;
		public unsafe void UnregisterCallback (global::Com.Alipay.Android.App.IRemoteServiceCallback p0)
		{
			if (id_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ == IntPtr.Zero)
				id_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_ = JNIEnv.GetMethodID (class_ref, "unregisterCallback", "(Lcom/alipay/android/app/IRemoteServiceCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterCallback_Lcom_alipay_android_app_IRemoteServiceCallback_, __args);
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
			global::Com.Alipay.Android.App.IAlixPay __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.App.IAlixPay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
