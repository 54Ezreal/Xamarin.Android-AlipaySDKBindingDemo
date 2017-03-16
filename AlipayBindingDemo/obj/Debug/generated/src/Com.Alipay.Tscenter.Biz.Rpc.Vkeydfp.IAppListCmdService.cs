using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp']/interface[@name='AppListCmdService']"
	[Register ("com/alipay/tscenter/biz/rpc/vkeydfp/AppListCmdService", "", "Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IAppListCmdServiceInvoker")]
	public partial interface IAppListCmdService : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp']/interface[@name='AppListCmdService']/method[@name='getAppListCmd' and count(parameter)=1 and parameter[1][@type='com.alipay.tscenter.biz.rpc.vkeydfp.request.AppListCmdRequest']]"
		[Register ("getAppListCmd", "(Lcom/alipay/tscenter/biz/rpc/vkeydfp/request/AppListCmdRequest;)Lcom/alipay/tscenter/biz/rpc/vkeydfp/result/AppListCmdResult;", "GetGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_Handler:Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IAppListCmdServiceInvoker, AlipayBindingDemo")]
		global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListCmdResult GetAppListCmd (global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.AppListCmdRequest p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.tscenter.biz.rpc.vkeydfp']/interface[@name='AppListCmdService']/method[@name='reGetAppListCmd' and count(parameter)=1 and parameter[1][@type='com.alipay.tscenter.biz.rpc.vkeydfp.request.AppListCmdRequest']]"
		[Register ("reGetAppListCmd", "(Lcom/alipay/tscenter/biz/rpc/vkeydfp/request/AppListCmdRequest;)Lcom/alipay/tscenter/biz/rpc/vkeydfp/result/AppListCmdResult;", "GetReGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_Handler:Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IAppListCmdServiceInvoker, AlipayBindingDemo")]
		global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListCmdResult ReGetAppListCmd (global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.AppListCmdRequest p0);

	}

	[global::Android.Runtime.Register ("com/alipay/tscenter/biz/rpc/vkeydfp/AppListCmdService", DoNotGenerateAcw=true)]
	internal class IAppListCmdServiceInvoker : global::Java.Lang.Object, IAppListCmdService {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/alipay/tscenter/biz/rpc/vkeydfp/AppListCmdService");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAppListCmdServiceInvoker); }
		}

		IntPtr class_ref;

		public static IAppListCmdService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppListCmdService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.alipay.tscenter.biz.rpc.vkeydfp.AppListCmdService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppListCmdServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_;
#pragma warning disable 0169
		static Delegate GetGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_Handler ()
		{
			if (cb_getAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ == null)
				cb_getAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_);
			return cb_getAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_;
		}

		static IntPtr n_GetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IAppListCmdService __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IAppListCmdService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.AppListCmdRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.AppListCmdRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAppListCmd (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_;
		public unsafe global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListCmdResult GetAppListCmd (global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.AppListCmdRequest p0)
		{
			if (id_getAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ == IntPtr.Zero)
				id_getAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ = JNIEnv.GetMethodID (class_ref, "getAppListCmd", "(Lcom/alipay/tscenter/biz/rpc/vkeydfp/request/AppListCmdRequest;)Lcom/alipay/tscenter/biz/rpc/vkeydfp/result/AppListCmdResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListCmdResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListCmdResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_reGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_;
#pragma warning disable 0169
		static Delegate GetReGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_Handler ()
		{
			if (cb_reGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ == null)
				cb_reGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_);
			return cb_reGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_;
		}

		static IntPtr n_ReGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IAppListCmdService __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.IAppListCmdService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.AppListCmdRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.AppListCmdRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReGetAppListCmd (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_reGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_;
		public unsafe global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListCmdResult ReGetAppListCmd (global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Request.AppListCmdRequest p0)
		{
			if (id_reGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ == IntPtr.Zero)
				id_reGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_ = JNIEnv.GetMethodID (class_ref, "reGetAppListCmd", "(Lcom/alipay/tscenter/biz/rpc/vkeydfp/request/AppListCmdRequest;)Lcom/alipay/tscenter/biz/rpc/vkeydfp/result/AppListCmdResult;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListCmdResult __ret = global::Java.Lang.Object.GetObject<global::Com.Alipay.Tscenter.Biz.Rpc.Vkeydfp.Result.AppListCmdResult> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reGetAppListCmd_Lcom_alipay_tscenter_biz_rpc_vkeydfp_request_AppListCmdRequest_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
