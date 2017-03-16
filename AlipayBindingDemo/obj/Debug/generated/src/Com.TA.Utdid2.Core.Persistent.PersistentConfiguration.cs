using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Core.Persistent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']"
	[global::Android.Runtime.Register ("com/ta/utdid2/core/persistent/PersistentConfiguration", DoNotGenerateAcw=true)]
	public partial class PersistentConfiguration : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/core/persistent/PersistentConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersistentConfiguration); }
		}

		protected PersistentConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/constructor[@name='PersistentConfiguration' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ZZ)V", "")]
		public unsafe PersistentConfiguration (global::Android.Content.Context p0, string p1, string p2, bool p3, bool p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (PersistentConfiguration)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ZZ)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZZ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;ZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ZZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getAll;
#pragma warning disable 0169
		static Delegate GetGetAllHandler ()
		{
			if (cb_getAll == null)
				cb_getAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAll);
			return cb_getAll;
		}

		static IntPtr n_GetAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		static IntPtr id_getAll;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, object> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/Map;", "GetGetAllHandler")]
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAll", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_commit;
#pragma warning disable 0169
		static Delegate GetCommitHandler ()
		{
			if (cb_commit == null)
				cb_commit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Commit);
			return cb_commit;
		}

		static bool n_Commit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Commit ();
		}
#pragma warning restore 0169

		static IntPtr id_commit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='commit' and count(parameter)=0]"
		[Register ("commit", "()Z", "GetCommitHandler")]
		public virtual unsafe bool Commit ()
		{
			if (id_commit == IntPtr.Zero)
				id_commit = JNIEnv.GetMethodID (class_ref, "commit", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_commit);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "commit", "()Z"));
			} finally {
			}
		}

		static Delegate cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static bool n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBoolean_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler")]
		public virtual unsafe bool GetBoolean (string p0)
		{
			if (id_getBoolean_Ljava_lang_String_ == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBoolean_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoolean", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getFloat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFloat_Ljava_lang_String_Handler ()
		{
			if (cb_getFloat_Ljava_lang_String_ == null)
				cb_getFloat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetFloat_Ljava_lang_String_);
			return cb_getFloat_Ljava_lang_String_;
		}

		static float n_GetFloat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetFloat (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFloat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='getFloat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFloat", "(Ljava/lang/String;)F", "GetGetFloat_Ljava_lang_String_Handler")]
		public virtual unsafe float GetFloat (string p0)
		{
			if (id_getFloat_Ljava_lang_String_ == IntPtr.Zero)
				id_getFloat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFloat", "(Ljava/lang/String;)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				float __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFloat_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFloat", "(Ljava/lang/String;)F"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getInt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Handler ()
		{
			if (cb_getInt_Ljava_lang_String_ == null)
				cb_getInt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetInt_Ljava_lang_String_);
			return cb_getInt_Ljava_lang_String_;
		}

		static int n_GetInt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getInt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInt", "(Ljava/lang/String;)I", "GetGetInt_Ljava_lang_String_Handler")]
		public virtual unsafe int GetInt (string p0)
		{
			if (id_getInt_Ljava_lang_String_ == IntPtr.Zero)
				id_getInt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInt_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInt", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLong_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler")]
		public virtual unsafe long GetLong (string p0)
		{
			if (id_getLong_Ljava_lang_String_ == IntPtr.Zero)
				id_getLong_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLong_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLong", "(Ljava/lang/String;)J"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string p0)
		{
			if (id_getString_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_putBoolean_Ljava_lang_String_Z == null)
				cb_putBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_PutBoolean_Ljava_lang_String_Z);
			return cb_putBoolean_Ljava_lang_String_Z;
		}

		static void n_PutBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutBoolean (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putBoolean_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='putBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("putBoolean", "(Ljava/lang/String;Z)V", "GetPutBoolean_Ljava_lang_String_ZHandler")]
		public virtual unsafe void PutBoolean (string p0, bool p1)
		{
			if (id_putBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_putBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "putBoolean", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putBoolean_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putBoolean", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putFloat_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetPutFloat_Ljava_lang_String_FHandler ()
		{
			if (cb_putFloat_Ljava_lang_String_F == null)
				cb_putFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_PutFloat_Ljava_lang_String_F);
			return cb_putFloat_Ljava_lang_String_F;
		}

		static void n_PutFloat_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutFloat (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putFloat_Ljava_lang_String_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='putFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("putFloat", "(Ljava/lang/String;F)V", "GetPutFloat_Ljava_lang_String_FHandler")]
		public virtual unsafe void PutFloat (string p0, float p1)
		{
			if (id_putFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_putFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "putFloat", "(Ljava/lang/String;F)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putFloat_Ljava_lang_String_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putFloat", "(Ljava/lang/String;F)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPutInt_Ljava_lang_String_IHandler ()
		{
			if (cb_putInt_Ljava_lang_String_I == null)
				cb_putInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_PutInt_Ljava_lang_String_I);
			return cb_putInt_Ljava_lang_String_I;
		}

		static void n_PutInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutInt (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putInt_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='putInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("putInt", "(Ljava/lang/String;I)V", "GetPutInt_Ljava_lang_String_IHandler")]
		public virtual unsafe void PutInt (string p0, int p1)
		{
			if (id_putInt_Ljava_lang_String_I == IntPtr.Zero)
				id_putInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "putInt", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putInt_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putInt", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPutLong_Ljava_lang_String_JHandler ()
		{
			if (cb_putLong_Ljava_lang_String_J == null)
				cb_putLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_PutLong_Ljava_lang_String_J);
			return cb_putLong_Ljava_lang_String_J;
		}

		static void n_PutLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutLong (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putLong_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='putLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("putLong", "(Ljava/lang/String;J)V", "GetPutLong_Ljava_lang_String_JHandler")]
		public virtual unsafe void PutLong (string p0, long p1)
		{
			if (id_putLong_Ljava_lang_String_J == IntPtr.Zero)
				id_putLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "putLong", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putLong_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putLong", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutString_Ljava_lang_String_Ljava_lang_String_);
			return cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PutString (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_putString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='putString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PutString (string p0, string p1)
		{
			if (id_putString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putString_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_reload;
#pragma warning disable 0169
		static Delegate GetReloadHandler ()
		{
			if (cb_reload == null)
				cb_reload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reload);
			return cb_reload;
		}

		static void n_Reload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reload ();
		}
#pragma warning restore 0169

		static IntPtr id_reload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='reload' and count(parameter)=0]"
		[Register ("reload", "()V", "GetReloadHandler")]
		public virtual unsafe void Reload ()
		{
			if (id_reload == IntPtr.Zero)
				id_reload = JNIEnv.GetMethodID (class_ref, "reload", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reload);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reload", "()V"));
			} finally {
			}
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.PersistentConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/class[@name='PersistentConfiguration']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
