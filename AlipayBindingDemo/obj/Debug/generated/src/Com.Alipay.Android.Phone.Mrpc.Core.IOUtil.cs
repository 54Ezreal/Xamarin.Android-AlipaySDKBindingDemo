using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='IOUtil']"
	[global::Android.Runtime.Register ("com/alipay/android/phone/mrpc/core/IOUtil", DoNotGenerateAcw=true)]
	public partial class IOUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/alipay/android/phone/mrpc/core/IOUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOUtil); }
		}

		protected IOUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='IOUtil']/constructor[@name='IOUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IOUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (IOUtil)) {
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

		static IntPtr id_InputStreamToByte_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='IOUtil']/method[@name='InputStreamToByte' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("InputStreamToByte", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] InputStreamToByte (global::System.IO.Stream p0)
		{
			if (id_InputStreamToByte_Ljava_io_InputStream_ == IntPtr.Zero)
				id_InputStreamToByte_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "InputStreamToByte", "(Ljava/io/InputStream;)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_InputStreamToByte_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_closeStream_Ljava_io_Closeable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='IOUtil']/method[@name='closeStream' and count(parameter)=1 and parameter[1][@type='java.io.Closeable']]"
		[Register ("closeStream", "(Ljava/io/Closeable;)V", "")]
		public static unsafe void CloseStream (global::Java.IO.ICloseable p0)
		{
			if (id_closeStream_Ljava_io_Closeable_ == IntPtr.Zero)
				id_closeStream_Ljava_io_Closeable_ = JNIEnv.GetStaticMethodID (class_ref, "closeStream", "(Ljava/io/Closeable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_closeStream_Ljava_io_Closeable_, __args);
			} finally {
			}
		}

		static IntPtr id_convertStreamToString_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='IOUtil']/method[@name='convertStreamToString' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string ConvertStreamToString (global::System.IO.Stream p0)
		{
			if (id_convertStreamToString_Ljava_io_InputStream_ == IntPtr.Zero)
				id_convertStreamToString_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertStreamToString_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fileToByte_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='IOUtil']/method[@name='fileToByte' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("fileToByte", "(Ljava/io/File;)[B", "")]
		public static unsafe byte[] FileToByte (global::Java.IO.File p0)
		{
			if (id_fileToByte_Ljava_io_File_ == IntPtr.Zero)
				id_fileToByte_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "fileToByte", "(Ljava/io/File;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fileToByte_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

	}
}
