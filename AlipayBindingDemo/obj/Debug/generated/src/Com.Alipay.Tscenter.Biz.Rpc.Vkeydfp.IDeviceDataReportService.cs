using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp']/interface[@name='DeviceDataReportService']"
	[Register ("com/alipay/tscenter/biz/rpc/vkeydfp/DeviceDataReportService", "", "Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IDeviceDataReportServiceInvoker")]
	public partial interface IDeviceDataReportService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp']/interface[@name='DeviceDataReportService']/method[@name='getAppList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAppList", "(Ljava/lang/String;)Lcom/alipay/tscenter/biz/rpc/vkeydfp/result/AppListResult;", "GetGetAppList_Ljava_lang_String_Handler:Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IDeviceDataReportServiceInvoker, AlipayBindingDemo")]
		global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListResult GetAppList (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp']/interface[@name='DeviceDataReportService']/method[@name='reportStaticData' and count(parameter)=1 and parameter[1][@type='com.alipay.tscenter.biz.rpc.vkeydfp.request.DeviceDataReportRequest']]"
		[Register ("reportStaticData", "(Lcom/alipay/tscenter/biz/rpc/vkeydfp/request/DeviceDataReportRequest;)Lcom/alipay/tscenter/biz/rpc/vkeydfp/result/DeviceDataReportResult;", "GetReportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_Handler:Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IDeviceDataReportServiceInvoker, AlipayBindingDemo")]
		global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.DeviceDataReportResult ReportStaticData (global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.DeviceDataReportRequest p0);

	}

	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/vkeydfp/DeviceDataReportService", DoNotGenerateAcw=true)]
	internal class IDeviceDataReportServiceInvoker : global::Java.Lang.Object, IDeviceDataReportService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/vkeydfp/DeviceDataReportService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDeviceDataReportServiceInvoker); }
		}

		IntPtr class_ref;

		public static IDeviceDataReportService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDeviceDataReportService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.tscenter.biz.rpc.vkeydfp.DeviceDataReportService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDeviceDataReportServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAppList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAppList_Ljava_lang_String_Handler ()
		{
			if (cb_getAppList_Ljava_lang_String_ == null)
				cb_getAppList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppList_Ljava_lang_String_);
			return cb_getAppList_Ljava_lang_String_;
		}

		static IntPtr n_GetAppList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IDeviceDataReportService __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IDeviceDataReportService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAppList (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAppList_Ljava_lang_String_;
		public unsafe global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListResult GetAppList (string p0)
		{
			if (id_getAppList_Ljava_lang_String_ == IntPtr.Zero)
				id_getAppList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAppList", "(Ljava/lang/String;)Lcom/alipay/tscenter/biz/rpc/vkeydfp/result/AppListResult;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_reportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_;
#pragma warning disable 0169
		static Delegate GetReportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_Handler ()
		{
			if (cb_reportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_ == null)
				cb_reportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_);
			return cb_reportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_;
		}

		static IntPtr n_ReportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IDeviceDataReportService __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IDeviceDataReportService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.DeviceDataReportRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.DeviceDataReportRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReportStaticData (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_reportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_;
		public unsafe global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.DeviceDataReportResult ReportStaticData (global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.DeviceDataReportRequest p0)
		{
			if (id_reportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_ == IntPtr.Zero)
				id_reportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_ = JNIEnv.GetMethodID (class_ref, "reportStaticData", "(Lcom/alipay/tscenter/biz/rpc/vkeydfp/request/DeviceDataReportRequest;)Lcom/alipay/tscenter/biz/rpc/vkeydfp/result/DeviceDataReportResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.DeviceDataReportResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.DeviceDataReportResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reportStaticData_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_DeviceDataReportRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
