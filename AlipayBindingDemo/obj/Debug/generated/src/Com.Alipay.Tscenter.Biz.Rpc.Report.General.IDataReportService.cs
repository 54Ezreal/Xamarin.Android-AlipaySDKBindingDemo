using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Report.General {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general']/interface[@name='DataReportService']"
	[Register ("com/alipay/tscenter/biz/rpc/report/general/DataReportService", "", "Com.Alipay.Tscenter.Biz.Rpc.Report.General.IDataReportServiceInvoker")]
	public partial interface IDataReportService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.report.general']/interface[@name='DataReportService']/method[@name='reportData' and count(parameter)=1 and parameter[1][@type='com.alipay.tscenter.biz.rpc.report.general.model.DataReportRequest']]"
		[Register ("reportData", "(Lcom/alipay/tscenter/biz/rpc/report/general/model/DataReportRequest;)Lcom/alipay/tscenter/biz/rpc/report/general/model/DataReportResult;", "GetReportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_Handler:Com.Alipay.Tscenter.Biz.Rpc.Report.General.IDataReportServiceInvoker, AlipayBindingDemo")]
		global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model.DataReportResult ReportData (global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model.DataReportRequest p0);

	}

	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/report/general/DataReportService", DoNotGenerateAcw=true)]
	internal class IDataReportServiceInvoker : global::Java.Lang.Object, IDataReportService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/report/general/DataReportService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDataReportServiceInvoker); }
		}

		IntPtr class_ref;

		public static IDataReportService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataReportService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.tscenter.biz.rpc.report.general.DataReportService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataReportServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_reportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_;
#pragma warning disable 0169
		static Delegate GetReportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_Handler ()
		{
			if (cb_reportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_ == null)
				cb_reportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_);
			return cb_reportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_;
		}

		static IntPtr n_ReportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.IDataReportService __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.IDataReportService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model.DataReportRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model.DataReportRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReportData (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_reportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_;
		public unsafe global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model.DataReportResult ReportData (global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model.DataReportRequest p0)
		{
			if (id_reportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_ == IntPtr.Zero)
				id_reportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_ = JNIEnv.GetMethodID (class_ref, "reportData", "(Lcom/alipay/tscenter/biz/rpc/report/general/model/DataReportRequest;)Lcom/alipay/tscenter/biz/rpc/report/general/model/DataReportResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model.DataReportResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Report.General.Model.DataReportResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reportData_Lcom_alipay_tscenter_biz_rpc_report_general_model_DataReportRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
