using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Apmobilesecuritysdk.Face {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk']"
	[global::Android.Runtime.Register ("com/alipay/apmobilesecuritysdk/face/APSecuritySdk", DoNotGenerateAcw=true)]
	public partial class APSecuritySdk : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/interface[@name='APSecuritySdk.InitResultListener']"
		[Register ("com/alipay/apmobilesecuritysdk/face/APSecuritySdk$InitResultListener", "", "Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk/IInitResultListenerInvoker")]
		public partial interface IInitResultListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/interface[@name='APSecuritySdk.InitResultListener']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.alipay.apmobilesecuritysdk.face.APSecuritySdk.TokenResult']]"
			[Register ("onResult", "(Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk$TokenResult;)V", "GetOnResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_Handler:Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk/IInitResultListenerInvoker, AlipayBindingDemo")]
			void OnResult (global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult p0);

		}

		[global::Android.Runtime.Register ("com/alipay/apmobilesecuritysdk/face/APSecuritySdk$InitResultListener", DoNotGenerateAcw=true)]
		internal class IInitResultListenerInvoker : global::Java.Lang.Object, IInitResultListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/apmobilesecuritysdk/face/APSecuritySdk$InitResultListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IInitResultListenerInvoker); }
			}

			IntPtr class_ref;

			public static IInitResultListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IInitResultListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.alipay.apmobilesecuritysdk.face.APSecuritySdk.InitResultListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IInitResultListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_;
#pragma warning disable 0169
			static Delegate GetOnResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_Handler ()
			{
				if (cb_onResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_ == null)
					cb_onResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_);
				return cb_onResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_;
			}

			static void n_OnResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.IInitResultListener __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.IInitResultListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResult (p0);
			}
#pragma warning restore 0169

			IntPtr id_onResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_;
			public unsafe void OnResult (global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult p0)
			{
				if (id_onResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_ == IntPtr.Zero)
					id_onResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk$TokenResult;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_, __args);
			}

		}

		public partial class InitResultEventArgs : global::System.EventArgs {

			public InitResultEventArgs (global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult p0)
			{
				this.p0 = p0;
			}

			global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult p0;
			public global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/alipay/apmobilesecuritysdk/face/APSecuritySdk_InitResultListenerImplementor")]
		internal sealed partial class IInitResultListenerImplementor : global::Java.Lang.Object, IInitResultListener {

			object sender;

			public IInitResultListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/alipay/apmobilesecuritysdk/face/APSecuritySdk_InitResultListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<InitResultEventArgs> Handler;
#pragma warning restore 0649

			public void OnResult (global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new InitResultEventArgs (p0));
			}

			internal static bool __IsEmpty (IInitResultListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk.TokenResult']"
		[global::Android.Runtime.Register ("com/alipay/apmobilesecuritysdk/face/APSecuritySdk$TokenResult", DoNotGenerateAcw=true)]
		public partial class TokenResult : global::Java.Lang.Object {


			static IntPtr apdid_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk.TokenResult']/field[@name='apdid']"
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

			static IntPtr apdidToken_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk.TokenResult']/field[@name='apdidToken']"
			[Register ("apdidToken")]
			public string ApdidToken {
				get {
					if (apdidToken_jfieldId == IntPtr.Zero)
						apdidToken_jfieldId = JNIEnv.GetFieldID (class_ref, "apdidToken", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, apdidToken_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (apdidToken_jfieldId == IntPtr.Zero)
						apdidToken_jfieldId = JNIEnv.GetFieldID (class_ref, "apdidToken", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, apdidToken_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr clientKey_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk.TokenResult']/field[@name='clientKey']"
			[Register ("clientKey")]
			public string ClientKey {
				get {
					if (clientKey_jfieldId == IntPtr.Zero)
						clientKey_jfieldId = JNIEnv.GetFieldID (class_ref, "clientKey", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, clientKey_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (clientKey_jfieldId == IntPtr.Zero)
						clientKey_jfieldId = JNIEnv.GetFieldID (class_ref, "clientKey", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, clientKey_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr umidToken_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk.TokenResult']/field[@name='umidToken']"
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
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/alipay/apmobilesecuritysdk/face/APSecuritySdk$TokenResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TokenResult); }
			}

			protected TokenResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk.TokenResult']/constructor[@name='APSecuritySdk.TokenResult' and count(parameter)=1 and parameter[1][@type='com.alipay.apmobilesecuritysdk.face.APSecuritySdk']]"
			[Register (".ctor", "(Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk;)V", "")]
			public unsafe TokenResult (global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (TokenResult)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_ == IntPtr.Zero)
						id_ctor_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/apmobilesecuritysdk/face/APSecuritySdk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (APSecuritySdk); }
		}

		protected APSecuritySdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getApdidToken;
#pragma warning disable 0169
		static Delegate GetGetApdidTokenHandler ()
		{
			if (cb_getApdidToken == null)
				cb_getApdidToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApdidToken);
			return cb_getApdidToken;
		}

		static IntPtr n_GetApdidToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApdidToken);
		}
#pragma warning restore 0169

		static IntPtr id_getApdidToken;
		public virtual unsafe string ApdidToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk']/method[@name='getApdidToken' and count(parameter)=0]"
			[Register ("getApdidToken", "()Ljava/lang/String;", "GetGetApdidTokenHandler")]
			get {
				if (id_getApdidToken == IntPtr.Zero)
					id_getApdidToken = JNIEnv.GetMethodID (class_ref, "getApdidToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApdidToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApdidToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSdkName;
#pragma warning disable 0169
		static Delegate GetGetSdkNameHandler ()
		{
			if (cb_getSdkName == null)
				cb_getSdkName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSdkName);
			return cb_getSdkName;
		}

		static IntPtr n_GetSdkName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SdkName);
		}
#pragma warning restore 0169

		static IntPtr id_getSdkName;
		public virtual unsafe string SdkName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk']/method[@name='getSdkName' and count(parameter)=0]"
			[Register ("getSdkName", "()Ljava/lang/String;", "GetGetSdkNameHandler")]
			get {
				if (id_getSdkName == IntPtr.Zero)
					id_getSdkName = JNIEnv.GetMethodID (class_ref, "getSdkName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSdkName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSdkName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetSdkVersionHandler ()
		{
			if (cb_getSdkVersion == null)
				cb_getSdkVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSdkVersion);
			return cb_getSdkVersion;
		}

		static IntPtr n_GetSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SdkVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getSdkVersion;
		public virtual unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get {
				if (id_getSdkVersion == IntPtr.Zero)
					id_getSdkVersion = JNIEnv.GetMethodID (class_ref, "getSdkVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSdkVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSdkVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk;", "")]
		public static unsafe global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk __ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTokenResult;
#pragma warning disable 0169
		static Delegate GetGetTokenResultHandler ()
		{
			if (cb_getTokenResult == null)
				cb_getTokenResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenResult);
			return cb_getTokenResult;
		}

		static IntPtr n_GetTokenResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTokenResult ());
		}
#pragma warning restore 0169

		static IntPtr id_getTokenResult;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk']/method[@name='getTokenResult' and count(parameter)=0]"
		[Register ("getTokenResult", "()Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk$TokenResult;", "GetGetTokenResultHandler")]
		public virtual unsafe global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult GetTokenResult ()
		{
			if (id_getTokenResult == IntPtr.Zero)
				id_getTokenResult = JNIEnv.GetMethodID (class_ref, "getTokenResult", "()Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk$TokenResult;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenResult), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.TokenResult> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenResult", "()Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk$TokenResult;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getUtdid_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk']/method[@name='getUtdid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUtdid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetUtdid (global::Android.Content.Context p0)
		{
			if (id_getUtdid_Landroid_content_Context_ == IntPtr.Zero)
				id_getUtdid_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUtdid", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUtdid_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_initToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_;
#pragma warning disable 0169
		static Delegate GetInitToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_Handler ()
		{
			if (cb_initToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_ == null)
				cb_initToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_InitToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_);
			return cb_initToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_;
		}

		static void n_InitToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.IInitResultListener p2 = (global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.IInitResultListener)global::Java.Lang.Object.GetObject<global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.IInitResultListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.InitToken (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_initToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.apmobilesecuritysdk.face']/class[@name='APSecuritySdk']/method[@name='initToken' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='com.alipay.apmobilesecuritysdk.face.APSecuritySdk.InitResultListener']]"
		[Register ("initToken", "(ILjava/util/Map;Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk$InitResultListener;)V", "GetInitToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_Handler")]
		public virtual unsafe void InitToken (int p0, global::System.Collections.Generic.IDictionary<string, string> p1, global::Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk.IInitResultListener p2)
		{
			if (id_initToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_ == IntPtr.Zero)
				id_initToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_ = JNIEnv.GetMethodID (class_ref, "initToken", "(ILjava/util/Map;Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk$InitResultListener;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initToken_ILjava_util_Map_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_InitResultListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initToken", "(ILjava/util/Map;Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk$InitResultListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
