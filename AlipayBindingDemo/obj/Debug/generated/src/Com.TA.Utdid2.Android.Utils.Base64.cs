using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.TA.Utdid2.Android.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']"
	[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/Base64", DoNotGenerateAcw=true)]
	public partial class Base64 : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='CRLF']"
		[Register ("CRLF")]
		public const int Crlf = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public const int Default = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='NO_CLOSE']"
		[Register ("NO_CLOSE")]
		public const int NoClose = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='NO_PADDING']"
		[Register ("NO_PADDING")]
		public const int NoPadding = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='NO_WRAP']"
		[Register ("NO_WRAP")]
		public const int NoWrap = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/field[@name='URL_SAFE']"
		[Register ("URL_SAFE")]
		public const int UrlSafe = (int) 8;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Coder']"
		[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/Base64$Coder", DoNotGenerateAcw=true)]
		public abstract partial class Coder : global::Java.Lang.Object {


			static IntPtr op_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Coder']/field[@name='op']"
			[Register ("op")]
			public int Op {
				get {
					if (op_jfieldId == IntPtr.Zero)
						op_jfieldId = JNIEnv.GetFieldID (class_ref, "op", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, op_jfieldId);
				}
				set {
					if (op_jfieldId == IntPtr.Zero)
						op_jfieldId = JNIEnv.GetFieldID (class_ref, "op", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, op_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr output_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Coder']/field[@name='output']"
			[Register ("output")]
			public IList<byte> Output {
				get {
					if (output_jfieldId == IntPtr.Zero)
						output_jfieldId = JNIEnv.GetFieldID (class_ref, "output", "[B");
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, output_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (output_jfieldId == IntPtr.Zero)
						output_jfieldId = JNIEnv.GetFieldID (class_ref, "output", "[B");
					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, output_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ta/utdid2/android/utils/Base64$Coder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Coder); }
			}

			protected Coder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_maxOutputSize_I;
#pragma warning disable 0169
			static Delegate GetMaxOutputSize_IHandler ()
			{
				if (cb_maxOutputSize_I == null)
					cb_maxOutputSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_MaxOutputSize_I);
				return cb_maxOutputSize_I;
			}

			static int n_MaxOutputSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.TA.Utdid2.Android.Utils.Base64.Coder __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Android.Utils.Base64.Coder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxOutputSize (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Coder']/method[@name='maxOutputSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxOutputSize", "(I)I", "GetMaxOutputSize_IHandler")]
			public abstract int MaxOutputSize (int p0);

			static Delegate cb_process_arrayBIIZ;
#pragma warning disable 0169
			static Delegate GetProcess_arrayBIIZHandler ()
			{
				if (cb_process_arrayBIIZ == null)
					cb_process_arrayBIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, bool>) n_Process_arrayBIIZ);
				return cb_process_arrayBIIZ;
			}

			static bool n_Process_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
			{
				global::Com.TA.Utdid2.Android.Utils.Base64.Coder __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Android.Utils.Base64.Coder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.Process (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Coder']/method[@name='process' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("process", "([BIIZ)Z", "GetProcess_arrayBIIZHandler")]
			public abstract bool Process (byte[] p0, int p1, int p2, bool p3);

		}

		[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/Base64$Coder", DoNotGenerateAcw=true)]
		internal partial class CoderInvoker : Coder {

			public CoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (CoderInvoker); }
			}

			static IntPtr id_maxOutputSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Coder']/method[@name='maxOutputSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxOutputSize", "(I)I", "GetMaxOutputSize_IHandler")]
			public override unsafe int MaxOutputSize (int p0)
			{
				if (id_maxOutputSize_I == IntPtr.Zero)
					id_maxOutputSize_I = JNIEnv.GetMethodID (class_ref, "maxOutputSize", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxOutputSize_I, __args);
				} finally {
				}
			}

			static IntPtr id_process_arrayBIIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Coder']/method[@name='process' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("process", "([BIIZ)Z", "GetProcess_arrayBIIZHandler")]
			public override unsafe bool Process (byte[] p0, int p1, int p2, bool p3)
			{
				if (id_process_arrayBIIZ == IntPtr.Zero)
					id_process_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "process", "([BIIZ)Z");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_process_arrayBIIZ, __args);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Decoder']"
		[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/Base64$Decoder", DoNotGenerateAcw=true)]
		public partial class Decoder : global::Com.TA.Utdid2.Android.Utils.Base64.Coder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ta/utdid2/android/utils/Base64$Decoder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Decoder); }
			}

			protected Decoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IarrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Decoder']/constructor[@name='Base64.Decoder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register (".ctor", "(I[B)V", "")]
			public unsafe Decoder (int p0, byte[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (((object) this).GetType () != typeof (Decoder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I[B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[B)V", __args);
						return;
					}

					if (id_ctor_IarrayB == IntPtr.Zero)
						id_ctor_IarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(I[B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayB, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_maxOutputSize_I;
#pragma warning disable 0169
			static Delegate GetMaxOutputSize_IHandler ()
			{
				if (cb_maxOutputSize_I == null)
					cb_maxOutputSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_MaxOutputSize_I);
				return cb_maxOutputSize_I;
			}

			static int n_MaxOutputSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.TA.Utdid2.Android.Utils.Base64.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Android.Utils.Base64.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxOutputSize (p0);
			}
#pragma warning restore 0169

			static IntPtr id_maxOutputSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Decoder']/method[@name='maxOutputSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxOutputSize", "(I)I", "GetMaxOutputSize_IHandler")]
			public override unsafe int MaxOutputSize (int p0)
			{
				if (id_maxOutputSize_I == IntPtr.Zero)
					id_maxOutputSize_I = JNIEnv.GetMethodID (class_ref, "maxOutputSize", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxOutputSize_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maxOutputSize", "(I)I"), __args);
				} finally {
				}
			}

			static Delegate cb_process_arrayBIIZ;
#pragma warning disable 0169
			static Delegate GetProcess_arrayBIIZHandler ()
			{
				if (cb_process_arrayBIIZ == null)
					cb_process_arrayBIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, bool>) n_Process_arrayBIIZ);
				return cb_process_arrayBIIZ;
			}

			static bool n_Process_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
			{
				global::Com.TA.Utdid2.Android.Utils.Base64.Decoder __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Android.Utils.Base64.Decoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.Process (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_process_arrayBIIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Decoder']/method[@name='process' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("process", "([BIIZ)Z", "GetProcess_arrayBIIZHandler")]
			public override unsafe bool Process (byte[] p0, int p1, int p2, bool p3)
			{
				if (id_process_arrayBIIZ == IntPtr.Zero)
					id_process_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "process", "([BIIZ)Z");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_process_arrayBIIZ, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "([BIIZ)Z"), __args);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Encoder']"
		[global::Android.Runtime.Register ("com/ta/utdid2/android/utils/Base64$Encoder", DoNotGenerateAcw=true)]
		public partial class Encoder : global::Com.TA.Utdid2.Android.Utils.Base64.Coder {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Encoder']/field[@name='LINE_GROUPS']"
			[Register ("LINE_GROUPS")]
			public const int LineGroups = (int) 19;

			static IntPtr do_cr_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Encoder']/field[@name='do_cr']"
			[Register ("do_cr")]
			public bool DoCr {
				get {
					if (do_cr_jfieldId == IntPtr.Zero)
						do_cr_jfieldId = JNIEnv.GetFieldID (class_ref, "do_cr", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, do_cr_jfieldId);
				}
				set {
					if (do_cr_jfieldId == IntPtr.Zero)
						do_cr_jfieldId = JNIEnv.GetFieldID (class_ref, "do_cr", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, do_cr_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr do_newline_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Encoder']/field[@name='do_newline']"
			[Register ("do_newline")]
			public bool DoNewline {
				get {
					if (do_newline_jfieldId == IntPtr.Zero)
						do_newline_jfieldId = JNIEnv.GetFieldID (class_ref, "do_newline", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, do_newline_jfieldId);
				}
				set {
					if (do_newline_jfieldId == IntPtr.Zero)
						do_newline_jfieldId = JNIEnv.GetFieldID (class_ref, "do_newline", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, do_newline_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr do_padding_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Encoder']/field[@name='do_padding']"
			[Register ("do_padding")]
			public bool DoPadding {
				get {
					if (do_padding_jfieldId == IntPtr.Zero)
						do_padding_jfieldId = JNIEnv.GetFieldID (class_ref, "do_padding", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, do_padding_jfieldId);
				}
				set {
					if (do_padding_jfieldId == IntPtr.Zero)
						do_padding_jfieldId = JNIEnv.GetFieldID (class_ref, "do_padding", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, do_padding_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/ta/utdid2/android/utils/Base64$Encoder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Encoder); }
			}

			protected Encoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IarrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Encoder']/constructor[@name='Base64.Encoder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
			[Register (".ctor", "(I[B)V", "")]
			public unsafe Encoder (int p0, byte[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (((object) this).GetType () != typeof (Encoder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I[B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I[B)V", __args);
						return;
					}

					if (id_ctor_IarrayB == IntPtr.Zero)
						id_ctor_IarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(I[B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IarrayB, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

			static Delegate cb_maxOutputSize_I;
#pragma warning disable 0169
			static Delegate GetMaxOutputSize_IHandler ()
			{
				if (cb_maxOutputSize_I == null)
					cb_maxOutputSize_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_MaxOutputSize_I);
				return cb_maxOutputSize_I;
			}

			static int n_MaxOutputSize_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.TA.Utdid2.Android.Utils.Base64.Encoder __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Android.Utils.Base64.Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxOutputSize (p0);
			}
#pragma warning restore 0169

			static IntPtr id_maxOutputSize_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Encoder']/method[@name='maxOutputSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("maxOutputSize", "(I)I", "GetMaxOutputSize_IHandler")]
			public override unsafe int MaxOutputSize (int p0)
			{
				if (id_maxOutputSize_I == IntPtr.Zero)
					id_maxOutputSize_I = JNIEnv.GetMethodID (class_ref, "maxOutputSize", "(I)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxOutputSize_I, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "maxOutputSize", "(I)I"), __args);
				} finally {
				}
			}

			static Delegate cb_process_arrayBIIZ;
#pragma warning disable 0169
			static Delegate GetProcess_arrayBIIZHandler ()
			{
				if (cb_process_arrayBIIZ == null)
					cb_process_arrayBIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, bool>) n_Process_arrayBIIZ);
				return cb_process_arrayBIIZ;
			}

			static bool n_Process_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
			{
				global::Com.TA.Utdid2.Android.Utils.Base64.Encoder __this = global::Java.Lang.Object.GetObject<global::Com.TA.Utdid2.Android.Utils.Base64.Encoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
				bool __ret = __this.Process (p0, p1, p2, p3);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_process_arrayBIIZ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64.Encoder']/method[@name='process' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("process", "([BIIZ)Z", "GetProcess_arrayBIIZHandler")]
			public override unsafe bool Process (byte[] p0, int p1, int p2, bool p3)
			{
				if (id_process_arrayBIIZ == IntPtr.Zero)
					id_process_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "process", "([BIIZ)Z");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_process_arrayBIIZ, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "process", "([BIIZ)Z"), __args);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/ta/utdid2/android/utils/Base64", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Base64); }
		}

		protected Base64 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_decode_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("decode", "([BI)[B", "")]
		public static unsafe byte[] Decode (byte[] p0, int p1)
		{
			if (id_decode_arrayBI == IntPtr.Zero)
				id_decode_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "decode", "([BI)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayBI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_decode_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='decode' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("decode", "([BIII)[B", "")]
		public static unsafe byte[] Decode (byte[] p0, int p1, int p2, int p3)
		{
			if (id_decode_arrayBIII == IntPtr.Zero)
				id_decode_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "decode", "([BIII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_arrayBIII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_decode_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("decode", "(Ljava/lang/String;I)[B", "")]
		public static unsafe byte[] Decode (string p0, int p1)
		{
			if (id_decode_Ljava_lang_String_I == IntPtr.Zero)
				id_decode_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "decode", "(Ljava/lang/String;I)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_decode_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_encode_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='encode' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encode", "([BI)[B", "")]
		public static unsafe byte[] Encode (byte[] p0, int p1)
		{
			if (id_encode_arrayBI == IntPtr.Zero)
				id_encode_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encode", "([BI)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayBI, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encode_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='encode' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encode", "([BIII)[B", "")]
		public static unsafe byte[] Encode (byte[] p0, int p1, int p2, int p3)
		{
			if (id_encode_arrayBIII == IntPtr.Zero)
				id_encode_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "encode", "([BIII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encode_arrayBIII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeToString_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='encodeToString' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("encodeToString", "([BI)Ljava/lang/String;", "")]
		public static unsafe string EncodeToString (byte[] p0, int p1)
		{
			if (id_encodeToString_arrayBI == IntPtr.Zero)
				id_encodeToString_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "encodeToString", "([BI)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeToString_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encodeToString_arrayBIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.ta.utdid2.android.utils']/class[@name='Base64']/method[@name='encodeToString' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("encodeToString", "([BIII)Ljava/lang/String;", "")]
		public static unsafe string EncodeToString (byte[] p0, int p1, int p2, int p3)
		{
			if (id_encodeToString_arrayBIII == IntPtr.Zero)
				id_encodeToString_arrayBIII = JNIEnv.GetStaticMethodID (class_ref, "encodeToString", "([BIII)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeToString_arrayBIII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
