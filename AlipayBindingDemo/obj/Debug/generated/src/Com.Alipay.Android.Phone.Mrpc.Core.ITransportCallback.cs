using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='TransportCallback']"
	[Register ("com/alipay/android/phone/mrpc/core/TransportCallback", "", "Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallbackInvoker")]
	public partial interface ITransportCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='TransportCallback']/method[@name='onCancelled' and count(parameter)=1 and parameter[1][@type='com.alipay.android.phone.mrpc.core.Request']]"
		[Register ("onCancelled", "(Lcom/alipay/android/phone/mrpc/core/Request;)V", "GetOnCancelled_Lcom_alipay_android_phone_mrpc_core_Request_Handler:Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallbackInvoker, AlipayBindingDemo")]
		void OnCancelled (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='TransportCallback']/method[@name='onFailed' and count(parameter)=3 and parameter[1][@type='com.alipay.android.phone.mrpc.core.Request'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onFailed", "(Lcom/alipay/android/phone/mrpc/core/Request;ILjava/lang/String;)V", "GetOnFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_Handler:Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallbackInvoker, AlipayBindingDemo")]
		void OnFailed (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0, int p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='TransportCallback']/method[@name='onPostExecute' and count(parameter)=2 and parameter[1][@type='com.alipay.android.phone.mrpc.core.Request'] and parameter[2][@type='com.alipay.android.phone.mrpc.core.Response']]"
		[Register ("onPostExecute", "(Lcom/alipay/android/phone/mrpc/core/Request;Lcom/alipay/android/phone/mrpc/core/Response;)V", "GetOnPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_Handler:Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallbackInvoker, AlipayBindingDemo")]
		void OnPostExecute (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0, global::Com.Alipay.Android.Phone.Mrpc.Core.Response p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='TransportCallback']/method[@name='onPreExecute' and count(parameter)=1 and parameter[1][@type='com.alipay.android.phone.mrpc.core.Request']]"
		[Register ("onPreExecute", "(Lcom/alipay/android/phone/mrpc/core/Request;)V", "GetOnPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_Handler:Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallbackInvoker, AlipayBindingDemo")]
		void OnPreExecute (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='TransportCallback']/method[@name='onProgressUpdate' and count(parameter)=2 and parameter[1][@type='com.alipay.android.phone.mrpc.core.Request'] and parameter[2][@type='double']]"
		[Register ("onProgressUpdate", "(Lcom/alipay/android/phone/mrpc/core/Request;D)V", "GetOnProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_DHandler:Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallbackInvoker, AlipayBindingDemo")]
		void OnProgressUpdate (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0, double p1);

	}

	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/TransportCallback", DoNotGenerateAcw=true)]
	internal class ITransportCallbackInvoker : global::Java.Lang.Object, ITransportCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/TransportCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITransportCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ITransportCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransportCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.android.phone.mrpc.core.TransportCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransportCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancelled_Lcom_alipay_android_phone_mrpc_core_Request_;
#pragma warning disable 0169
		static Delegate GetOnCancelled_Lcom_alipay_android_phone_mrpc_core_Request_Handler ()
		{
			if (cb_onCancelled_Lcom_alipay_android_phone_mrpc_core_Request_ == null)
				cb_onCancelled_Lcom_alipay_android_phone_mrpc_core_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancelled_Lcom_alipay_android_phone_mrpc_core_Request_);
			return cb_onCancelled_Lcom_alipay_android_phone_mrpc_core_Request_;
		}

		static void n_OnCancelled_Lcom_alipay_android_phone_mrpc_core_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelled (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCancelled_Lcom_alipay_android_phone_mrpc_core_Request_;
		public unsafe void OnCancelled (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0)
		{
			if (id_onCancelled_Lcom_alipay_android_phone_mrpc_core_Request_ == IntPtr.Zero)
				id_onCancelled_Lcom_alipay_android_phone_mrpc_core_Request_ = JNIEnv.GetMethodID (class_ref, "onCancelled", "(Lcom/alipay/android/phone/mrpc/core/Request;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancelled_Lcom_alipay_android_phone_mrpc_core_Request_, __args);
		}

		static Delegate cb_onFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_Handler ()
		{
			if (cb_onFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_ == null)
				cb_onFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_);
			return cb_onFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_;
		}

		static void n_OnFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnFailed (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_;
		public unsafe void OnFailed (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0, int p1, string p2)
		{
			if (id_onFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_ == IntPtr.Zero)
				id_onFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Lcom/alipay/android/phone/mrpc/core/Request;ILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_Lcom_alipay_android_phone_mrpc_core_Request_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_;
#pragma warning disable 0169
		static Delegate GetOnPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_Handler ()
		{
			if (cb_onPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_ == null)
				cb_onPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_);
			return cb_onPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_;
		}

		static void n_OnPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.Response p1 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Response> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnPostExecute (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_;
		public unsafe void OnPostExecute (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0, global::Com.Alipay.Android.Phone.Mrpc.Core.Response p1)
		{
			if (id_onPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_ == IntPtr.Zero)
				id_onPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Lcom/alipay/android/phone/mrpc/core/Request;Lcom/alipay/android/phone/mrpc/core/Response;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostExecute_Lcom_alipay_android_phone_mrpc_core_Request_Lcom_alipay_android_phone_mrpc_core_Response_, __args);
		}

		static Delegate cb_onPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_;
#pragma warning disable 0169
		static Delegate GetOnPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_Handler ()
		{
			if (cb_onPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_ == null)
				cb_onPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_);
			return cb_onPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_;
		}

		static void n_OnPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPreExecute (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_;
		public unsafe void OnPreExecute (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0)
		{
			if (id_onPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_ == IntPtr.Zero)
				id_onPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_ = JNIEnv.GetMethodID (class_ref, "onPreExecute", "(Lcom/alipay/android/phone/mrpc/core/Request;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPreExecute_Lcom_alipay_android_phone_mrpc_core_Request_, __args);
		}

		static Delegate cb_onProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D;
#pragma warning disable 0169
		static Delegate GetOnProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_DHandler ()
		{
			if (cb_onProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D == null)
				cb_onProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_OnProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D);
			return cb_onProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D;
		}

		static void n_OnProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.ITransportCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnProgressUpdate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D;
		public unsafe void OnProgressUpdate (global::Com.Alipay.Android.Phone.Mrpc.Core.Request p0, double p1)
		{
			if (id_onProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D == IntPtr.Zero)
				id_onProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "(Lcom/alipay/android/phone/mrpc/core/Request;D)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgressUpdate_Lcom_alipay_android_phone_mrpc_core_Request_D, __args);
		}

	}

}
