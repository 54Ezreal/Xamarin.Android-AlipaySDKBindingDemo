using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Core.Persistent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.MyEditor']"
	[Register ("com/ta/utdid2/core/persistent/MySharedPreferences$MyEditor", "", "Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditorInvoker")]
	public partial interface IMySharedPreferencesMyEditor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.MyEditor']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "GetClearHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditorInvoker, AlipayBindingDemo")]
		global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.MyEditor']/method[@name='commit' and count(parameter)=0]"
		[Register ("commit", "()Z", "GetCommitHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditorInvoker, AlipayBindingDemo")]
		bool Commit ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.MyEditor']/method[@name='putBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("putBoolean", "(Ljava/lang/String;Z)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "GetPutBoolean_Ljava_lang_String_ZHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditorInvoker, AlipayBindingDemo")]
		global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutBoolean (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.MyEditor']/method[@name='putFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("putFloat", "(Ljava/lang/String;F)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "GetPutFloat_Ljava_lang_String_FHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditorInvoker, AlipayBindingDemo")]
		global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutFloat (string p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.MyEditor']/method[@name='putInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("putInt", "(Ljava/lang/String;I)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "GetPutInt_Ljava_lang_String_IHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditorInvoker, AlipayBindingDemo")]
		global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutInt (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.MyEditor']/method[@name='putLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("putLong", "(Ljava/lang/String;J)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "GetPutLong_Ljava_lang_String_JHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditorInvoker, AlipayBindingDemo")]
		global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutLong (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.MyEditor']/method[@name='putString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "GetPutString_Ljava_lang_String_Ljava_lang_String_Handler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditorInvoker, AlipayBindingDemo")]
		global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutString (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.MyEditor']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "GetRemove_Ljava_lang_String_Handler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditorInvoker, AlipayBindingDemo")]
		global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor Remove (string p0);

	}

	[global::Android.Runtime.Register ("com/ta/utdid2/core/persistent/MySharedPreferences$MyEditor", DoNotGenerateAcw=true)]
	internal class IMySharedPreferencesMyEditorInvoker : global::Java.Lang.Object, IMySharedPreferencesMyEditor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ta/utdid2/core/persistent/MySharedPreferences$MyEditor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMySharedPreferencesMyEditorInvoker); }
		}

		IntPtr class_ref;

		public static IMySharedPreferencesMyEditor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMySharedPreferencesMyEditor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ta.utdid2.core.persistent.MySharedPreferences.MyEditor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMySharedPreferencesMyEditorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static IntPtr n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clear ());
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
			return global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clear), JniHandleOwnership.TransferLocalRef);
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
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Commit ();
		}
#pragma warning restore 0169

		IntPtr id_commit;
		public unsafe bool Commit ()
		{
			if (id_commit == IntPtr.Zero)
				id_commit = JNIEnv.GetMethodID (class_ref, "commit", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_commit);
		}

		static Delegate cb_putBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPutBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_putBoolean_Ljava_lang_String_Z == null)
				cb_putBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_PutBoolean_Ljava_lang_String_Z);
			return cb_putBoolean_Ljava_lang_String_Z;
		}

		static IntPtr n_PutBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutBoolean (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_putBoolean_Ljava_lang_String_Z;
		public unsafe global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutBoolean (string p0, bool p1)
		{
			if (id_putBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_putBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "putBoolean", "(Ljava/lang/String;Z)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_putBoolean_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_putFloat_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetPutFloat_Ljava_lang_String_FHandler ()
		{
			if (cb_putFloat_Ljava_lang_String_F == null)
				cb_putFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, IntPtr>) n_PutFloat_Ljava_lang_String_F);
			return cb_putFloat_Ljava_lang_String_F;
		}

		static IntPtr n_PutFloat_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutFloat (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_putFloat_Ljava_lang_String_F;
		public unsafe global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutFloat (string p0, float p1)
		{
			if (id_putFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_putFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "putFloat", "(Ljava/lang/String;F)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_putFloat_Ljava_lang_String_F, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_putInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetPutInt_Ljava_lang_String_IHandler ()
		{
			if (cb_putInt_Ljava_lang_String_I == null)
				cb_putInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_PutInt_Ljava_lang_String_I);
			return cb_putInt_Ljava_lang_String_I;
		}

		static IntPtr n_PutInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutInt (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_putInt_Ljava_lang_String_I;
		public unsafe global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutInt (string p0, int p1)
		{
			if (id_putInt_Ljava_lang_String_I == IntPtr.Zero)
				id_putInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "putInt", "(Ljava/lang/String;I)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_putInt_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_putLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPutLong_Ljava_lang_String_JHandler ()
		{
			if (cb_putLong_Ljava_lang_String_J == null)
				cb_putLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_PutLong_Ljava_lang_String_J);
			return cb_putLong_Ljava_lang_String_J;
		}

		static IntPtr n_PutLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutLong (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_putLong_Ljava_lang_String_J;
		public unsafe global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutLong (string p0, long p1)
		{
			if (id_putLong_Ljava_lang_String_J == IntPtr.Zero)
				id_putLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "putLong", "(Ljava/lang/String;J)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_putLong_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_putString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PutString_Ljava_lang_String_Ljava_lang_String_);
			return cb_putString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PutString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PutString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_putString_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor PutString (string p0, string p1)
		{
			if (id_putString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_putString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putString", "(Ljava/lang/String;Ljava/lang/String;)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_putString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static IntPtr n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Remove (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_;
		public unsafe global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor __ret = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.OnSharedPreferenceChangeListener']"
	[Register ("com/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener", "", "Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListenerInvoker")]
	public partial interface IMySharedPreferencesOnSharedPreferenceChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences.OnSharedPreferenceChangeListener']/method[@name='onSharedPreferenceChanged' and count(parameter)=2 and parameter[1][@type='com.ta.utdid2.core.persistent.MySharedPreferences'] and parameter[2][@type='java.lang.String']]"
		[Register ("onSharedPreferenceChanged", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences;Ljava/lang/String;)V", "GetOnSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_Handler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListenerInvoker, AlipayBindingDemo")]
		void OnSharedPreferenceChanged (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences p0, string p1);

	}

	[global::Android.Runtime.Register ("com/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener", DoNotGenerateAcw=true)]
	internal class IMySharedPreferencesOnSharedPreferenceChangeListenerInvoker : global::Java.Lang.Object, IMySharedPreferencesOnSharedPreferenceChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMySharedPreferencesOnSharedPreferenceChangeListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMySharedPreferencesOnSharedPreferenceChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMySharedPreferencesOnSharedPreferenceChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ta.utdid2.core.persistent.MySharedPreferences.OnSharedPreferenceChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMySharedPreferencesOnSharedPreferenceChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_Handler ()
		{
			if (cb_onSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_ == null)
				cb_onSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_);
			return cb_onSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_;
		}

		static void n_OnSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences p0 = (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences)global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSharedPreferenceChanged (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_;
		public unsafe void OnSharedPreferenceChanged (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences p0, string p1)
		{
			if (id_onSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_ == IntPtr.Zero)
				id_onSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSharedPreferenceChanged", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class MySharedPreferencesOnSharedPreferenceChangeEventArgs : global::System.EventArgs {

		public MySharedPreferencesOnSharedPreferenceChangeEventArgs (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences p0;
		public global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/ta/utdid2/core/persistent/MySharedPreferences_OnSharedPreferenceChangeListenerImplementor")]
	internal sealed partial class IMySharedPreferencesOnSharedPreferenceChangeListenerImplementor : global::Java.Lang.Object, IMySharedPreferencesOnSharedPreferenceChangeListener {

		object sender;

		public IMySharedPreferencesOnSharedPreferenceChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/ta/utdid2/core/persistent/MySharedPreferences_OnSharedPreferenceChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MySharedPreferencesOnSharedPreferenceChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnSharedPreferenceChanged (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MySharedPreferencesOnSharedPreferenceChangeEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IMySharedPreferencesOnSharedPreferenceChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']"
	[Register ("com/ta/utdid2/core/persistent/MySharedPreferences", "", "Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker")]
	public partial interface IMySharedPreferences : IJavaObject {

		global::System.Collections.Generic.IDictionary<string, object> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/Map;", "GetGetAllHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='checkFile' and count(parameter)=0]"
		[Register ("checkFile", "()Z", "GetCheckFileHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		bool CheckFile ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		bool Contains (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='edit' and count(parameter)=0]"
		[Register ("edit", "()Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;", "GetEditHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor Edit ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Z)Z", "GetGetBoolean_Ljava_lang_String_ZHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		bool GetBoolean (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='getFloat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register ("getFloat", "(Ljava/lang/String;F)F", "GetGetFloat_Ljava_lang_String_FHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		float GetFloat (string p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;I)I", "GetGetInt_Ljava_lang_String_IHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		int GetInt (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='getLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getLong", "(Ljava/lang/String;J)J", "GetGetLong_Ljava_lang_String_JHandler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		long GetLong (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Handler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		string GetString (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='registerOnSharedPreferenceChangeListener' and count(parameter)=1 and parameter[1][@type='com.ta.utdid2.core.persistent.MySharedPreferences.OnSharedPreferenceChangeListener']]"
		[Register ("registerOnSharedPreferenceChangeListener", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener;)V", "GetRegisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_Handler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		void RegisterOnSharedPreferenceChangeListener (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.core.persistent']/interface[@name='MySharedPreferences']/method[@name='unregisterOnSharedPreferenceChangeListener' and count(parameter)=1 and parameter[1][@type='com.ta.utdid2.core.persistent.MySharedPreferences.OnSharedPreferenceChangeListener']]"
		[Register ("unregisterOnSharedPreferenceChangeListener", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener;)V", "GetUnregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_Handler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesInvoker, AlipayBindingDemo")]
		void UnregisterOnSharedPreferenceChangeListener (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener p0);

	}

	[global::Android.Runtime.Register ("com/ta/utdid2/core/persistent/MySharedPreferences", DoNotGenerateAcw=true)]
	internal class IMySharedPreferencesInvoker : global::Java.Lang.Object, IMySharedPreferences {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/ta/utdid2/core/persistent/MySharedPreferences");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMySharedPreferencesInvoker); }
		}

		IntPtr class_ref;

		public static IMySharedPreferences GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMySharedPreferences> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.ta.utdid2.core.persistent.MySharedPreferences"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMySharedPreferencesInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		IntPtr id_getAll;
		public unsafe global::System.Collections.Generic.IDictionary<string, object> All {
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_checkFile;
#pragma warning disable 0169
		static Delegate GetCheckFileHandler ()
		{
			if (cb_checkFile == null)
				cb_checkFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckFile);
			return cb_checkFile;
		}

		static bool n_CheckFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckFile ();
		}
#pragma warning restore 0169

		IntPtr id_checkFile;
		public unsafe bool CheckFile ()
		{
			if (id_checkFile == IntPtr.Zero)
				id_checkFile = JNIEnv.GetMethodID (class_ref, "checkFile", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkFile);
		}

		static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Ljava_lang_String_;
		public unsafe bool Contains (string p0)
		{
			if (id_contains_Ljava_lang_String_ == IntPtr.Zero)
				id_contains_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "contains", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_edit;
#pragma warning disable 0169
		static Delegate GetEditHandler ()
		{
			if (cb_edit == null)
				cb_edit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Edit);
			return cb_edit;
		}

		static IntPtr n_Edit (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Edit ());
		}
#pragma warning restore 0169

		IntPtr id_edit;
		public unsafe global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor Edit ()
		{
			if (id_edit == IntPtr.Zero)
				id_edit = JNIEnv.GetMethodID (class_ref, "edit", "()Lcom/ta/utdid2/core/persistent/MySharedPreferences$MyEditor;");
			return global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesMyEditor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_edit), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_getBoolean_Ljava_lang_String_Z == null)
				cb_getBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, bool>) n_GetBoolean_Ljava_lang_String_Z);
			return cb_getBoolean_Ljava_lang_String_Z;
		}

		static bool n_GetBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBoolean_Ljava_lang_String_Z;
		public unsafe bool GetBoolean (string p0, bool p1)
		{
			if (id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getBoolean", "(Ljava/lang/String;Z)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBoolean_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getFloat_Ljava_lang_String_F;
#pragma warning disable 0169
		static Delegate GetGetFloat_Ljava_lang_String_FHandler ()
		{
			if (cb_getFloat_Ljava_lang_String_F == null)
				cb_getFloat_Ljava_lang_String_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float>) n_GetFloat_Ljava_lang_String_F);
			return cb_getFloat_Ljava_lang_String_F;
		}

		static float n_GetFloat_Ljava_lang_String_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetFloat (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFloat_Ljava_lang_String_F;
		public unsafe float GetFloat (string p0, float p1)
		{
			if (id_getFloat_Ljava_lang_String_F == IntPtr.Zero)
				id_getFloat_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "getFloat", "(Ljava/lang/String;F)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			float __ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFloat_Ljava_lang_String_F, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Ljava_lang_String_I == null)
				cb_getInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_GetInt_Ljava_lang_String_I);
			return cb_getInt_Ljava_lang_String_I;
		}

		static int n_GetInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getInt_Ljava_lang_String_I;
		public unsafe int GetInt (string p0, int p1)
		{
			if (id_getInt_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "getInt", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInt_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_JHandler ()
		{
			if (cb_getLong_Ljava_lang_String_J == null)
				cb_getLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_GetLong_Ljava_lang_String_J);
			return cb_getLong_Ljava_lang_String_J;
		}

		static long n_GetLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getLong_Ljava_lang_String_J;
		public unsafe long GetLong (string p0, long p1)
		{
			if (id_getLong_Ljava_lang_String_J == IntPtr.Zero)
				id_getLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "getLong", "(Ljava/lang/String;J)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLong_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetString_Ljava_lang_String_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string GetString (string p0, string p1)
		{
			if (id_getString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_;
#pragma warning disable 0169
		static Delegate GetRegisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_Handler ()
		{
			if (cb_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ == null)
				cb_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_);
			return cb_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_;
		}

		static void n_RegisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener p0 = (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener)global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterOnSharedPreferenceChangeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_;
		public unsafe void RegisterOnSharedPreferenceChangeListener (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener p0)
		{
			if (id_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ == IntPtr.Zero)
				id_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ = JNIEnv.GetMethodID (class_ref, "registerOnSharedPreferenceChangeListener", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_, __args);
		}

		static Delegate cb_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_Handler ()
		{
			if (cb_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ == null)
				cb_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_);
			return cb_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_;
		}

		static void n_UnregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener p0 = (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener)global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterOnSharedPreferenceChangeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_;
		public unsafe void UnregisterOnSharedPreferenceChangeListener (global::Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListener p0)
		{
			if (id_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ == IntPtr.Zero)
				id_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_ = JNIEnv.GetMethodID (class_ref, "unregisterOnSharedPreferenceChangeListener", "(Lcom/ta/utdid2/core/persistent/MySharedPreferences$OnSharedPreferenceChangeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterOnSharedPreferenceChangeListener_Lcom_ta_utdid2_core_persistent_MySharedPreferences_OnSharedPreferenceChangeListener_, __args);
		}

	}

}
