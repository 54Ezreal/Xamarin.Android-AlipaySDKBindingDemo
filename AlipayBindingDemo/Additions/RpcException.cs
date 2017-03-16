using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Alipay.Android.Phone.Mrpc.Core
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']"
    [global::Android.Runtime.Register("com/alipay/android/phone/mrpc/core/RpcException", DoNotGenerateAcw = true)]
    public partial class RpcException : global::Java.Lang.RuntimeException
    {

        [Register("com/alipay/android/phone/mrpc/core/RpcException$ErrorCode", DoNotGenerateAcw = true)]
        public abstract class ErrorCode : Java.Lang.Object
        {

            internal ErrorCode()
            {
            }

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_DESERIALIZER_ERROR']"
            [Register("CLIENT_DESERIALIZER_ERROR")]
            public const int ClientDeserializerError = (int)10;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_HANDLE_ERROR']"
            [Register("CLIENT_HANDLE_ERROR")]
            public const int ClientHandleError = (int)9;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_INTERUPTED_ERROR']"
            [Register("CLIENT_INTERUPTED_ERROR")]
            public const int ClientInteruptedError = (int)13;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_LOGIN_FAIL_ERROR']"
            [Register("CLIENT_LOGIN_FAIL_ERROR")]
            public const int ClientLoginFailError = (int)11;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_AUTH_ERROR']"
            [Register("CLIENT_NETWORK_AUTH_ERROR")]
            public const int ClientNetworkAuthError = (int)15;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_CACHE_ERROR']"
            [Register("CLIENT_NETWORK_CACHE_ERROR")]
            public const int ClientNetworkCacheError = (int)14;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_CONNECTION_ERROR']"
            [Register("CLIENT_NETWORK_CONNECTION_ERROR")]
            public const int ClientNetworkConnectionError = (int)4;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_DNS_ERROR']"
            [Register("CLIENT_NETWORK_DNS_ERROR")]
            public const int ClientNetworkDnsError = (int)16;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_ERROR']"
            [Register("CLIENT_NETWORK_ERROR")]
            public const int ClientNetworkError = (int)7;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_SCHEDULE_ERROR']"
            [Register("CLIENT_NETWORK_SCHEDULE_ERROR")]
            public const int ClientNetworkScheduleError = (int)8;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_SERVER_ERROR']"
            [Register("CLIENT_NETWORK_SERVER_ERROR")]
            public const int ClientNetworkServerError = (int)6;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_SOCKET_ERROR']"
            [Register("CLIENT_NETWORK_SOCKET_ERROR")]
            public const int ClientNetworkSocketError = (int)5;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_SSL_ERROR']"
            [Register("CLIENT_NETWORK_SSL_ERROR")]
            public const int ClientNetworkSslError = (int)3;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_NETWORK_UNAVAILABLE_ERROR']"
            [Register("CLIENT_NETWORK_UNAVAILABLE_ERROR")]
            public const int ClientNetworkUnavailableError = (int)2;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_TRANSPORT_UNAVAILABAL_ERROR']"
            [Register("CLIENT_TRANSPORT_UNAVAILABAL_ERROR")]
            public const int ClientTransportUnavailabalError = (int)1;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_UNKNOWN_ERROR']"
            [Register("CLIENT_UNKNOWN_ERROR")]
            public const int ClientUnknownError = (int)0;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='CLIENT_USER_CHANGE_ERROR']"
            [Register("CLIENT_USER_CHANGE_ERROR")]
            public const int ClientUserChangeError = (int)12;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='OK']"
            [Register("OK")]
            public const int Ok = (int)1000;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_BIZEXCEPTION']"
            [Register("SERVER_BIZEXCEPTION")]
            public const int ServerBizexception = (int)6666;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_CREATEPROXYERROR']"
            [Register("SERVER_CREATEPROXYERROR")]
            public const int ServerCreateproxyerror = (int)4003;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_ILLEGALACCESS']"
            [Register("SERVER_ILLEGALACCESS")]
            public const int ServerIllegalaccess = (int)6003;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_ILLEGALARGUMENT']"
            [Register("SERVER_ILLEGALARGUMENT")]
            public const int ServerIllegalargument = (int)6005;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_INVOKEEXCEEDLIMIT']"
            [Register("SERVER_INVOKEEXCEEDLIMIT")]
            public const int ServerInvokeexceedlimit = (int)1002;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_JSONPARSEREXCEPTION']"
            [Register("SERVER_JSONPARSEREXCEPTION")]
            public const int ServerJsonparserexception = (int)6004;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_METHODNOTFOUND']"
            [Register("SERVER_METHODNOTFOUND")]
            public const int ServerMethodnotfound = (int)6001;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_OPERATIONTYPEMISSED']"
            [Register("SERVER_OPERATIONTYPEMISSED")]
            public const int ServerOperationtypemissed = (int)3000;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_PARAMMISSING']"
            [Register("SERVER_PARAMMISSING")]
            public const int ServerParammissing = (int)6002;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_PERMISSIONDENY']"
            [Register("SERVER_PERMISSIONDENY")]
            public const int ServerPermissiondeny = (int)1001;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_REMOTEACCESSEXCEPTION']"
            [Register("SERVER_REMOTEACCESSEXCEPTION")]
            public const int ServerRemoteaccessexception = (int)4002;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_REQUESTDATAMISSED']"
            [Register("SERVER_REQUESTDATAMISSED")]
            public const int ServerRequestdatamissed = (int)3001;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_REQUESTTIMEOUT']"
            [Register("SERVER_REQUESTTIMEOUT")]
            public const int ServerRequesttimeout = (int)4001;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_SERVICENOTFOUND']"
            [Register("SERVER_SERVICENOTFOUND")]
            public const int ServerServicenotfound = (int)6000;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_SESSIONSTATUS']"
            [Register("SERVER_SESSIONSTATUS")]
            public const int ServerSessionstatus = (int)2000;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_UNKNOWERROR']"
            [Register("SERVER_UNKNOWERROR")]
            public const int ServerUnknowerror = (int)5000;

            // Metadata.xml XPath field reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/interface[@name='RpcException.ErrorCode']/field[@name='SERVER_VALUEINVALID']"
            [Register("SERVER_VALUEINVALID")]
            public const int ServerValueinvalid = (int)3002;
        }

        [Register("com/alipay/android/phone/mrpc/core/RpcException$ErrorCode", DoNotGenerateAcw = true)]
        [global::System.Obsolete("Use the 'ErrorCode' type. This type will be removed in a future release.")]
        public abstract class ErrorCodeConsts : ErrorCode
        {

            private ErrorCodeConsts()
            {
            }
        }


        internal static IntPtr java_class_handle;
        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/alipay/android/phone/mrpc/core/RpcException", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(RpcException); }
        }

        protected RpcException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor_Ljava_lang_String_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']/constructor[@name='RpcException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
        [Register(".ctor", "(Ljava/lang/String;)V", "")]
        public unsafe RpcException(string p0)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            
            if (this.Handle != IntPtr.Zero)
                return;

            IntPtr native_p0 = JNIEnv.NewString(p0);
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(native_p0);
                if (((object)this).GetType() != typeof(RpcException))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Ljava/lang/String;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(this.Handle, "(Ljava/lang/String;)V", __args);
                    return;
                }

                if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
                    id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Ljava/lang/String;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Ljava_lang_String_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(this.Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p0);
            }
        }

        static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_Throwable_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']/constructor[@name='RpcException' and count(parameter)=3 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
        [Register(".ctor", "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
        public unsafe RpcException(global::Java.Lang.Integer p0, string p1, global::Java.Lang.Throwable p2)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (this.Handle != IntPtr.Zero)
                return;

            IntPtr native_p1 = JNIEnv.NewString(p1);
            try
            {
                JValue* __args = stackalloc JValue[3];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(native_p1);
                __args[2] = new JValue(p2);
                if (((object)this).GetType() != typeof(RpcException))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/Throwable;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(this.Handle, "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/Throwable;)V", __args);
                    return;
                }

                if (id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
                    id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/Throwable;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_Throwable_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(this.Handle, class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_Ljava_lang_Throwable_, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p1);
            }
        }

        static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_Throwable_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']/constructor[@name='RpcException' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Throwable']]"
        [Register(".ctor", "(Ljava/lang/Integer;Ljava/lang/Throwable;)V", "")]
        public unsafe RpcException(global::Java.Lang.Integer p0, global::Java.Lang.Throwable p1)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (this.Handle != IntPtr.Zero)
                return;

            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(p1);
                if (((object)this).GetType() != typeof(RpcException))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Ljava/lang/Integer;Ljava/lang/Throwable;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(this.Handle, "(Ljava/lang/Integer;Ljava/lang/Throwable;)V", __args);
                    return;
                }

                if (id_ctor_Ljava_lang_Integer_Ljava_lang_Throwable_ == IntPtr.Zero)
                    id_ctor_Ljava_lang_Integer_Ljava_lang_Throwable_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Ljava/lang/Integer;Ljava/lang/Throwable;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_Throwable_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(this.Handle, class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_Throwable_, __args);
            }
            finally
            {
            }
        }

        static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_String_;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']/constructor[@name='RpcException' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
        [Register(".ctor", "(Ljava/lang/Integer;Ljava/lang/String;)V", "")]
        public unsafe RpcException(global::Java.Lang.Integer p0, string p1)
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (this.Handle != IntPtr.Zero)
                return;

            IntPtr native_p1 = JNIEnv.NewString(p1);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(native_p1);
                if (((object)this).GetType() != typeof(RpcException))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(Ljava/lang/Integer;Ljava/lang/String;)V", __args),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(this.Handle, "(Ljava/lang/Integer;Ljava/lang/String;)V", __args);
                    return;
                }

                if (id_ctor_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
                    id_ctor_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "<init>", "(Ljava/lang/Integer;Ljava/lang/String;)V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_, __args),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(this.Handle, class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_, __args);
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p1);
            }
        }

        static Delegate cb_getCode;
#pragma warning disable 0169
        static Delegate GetGetCodeHandler()
        {
            if (cb_getCode == null)
                cb_getCode = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int>)n_GetCode);
            return cb_getCode;
        }

        static int n_GetCode(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Alipay.Android.Phone.Mrpc.Core.RpcException __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcException>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return __this.Code;
        }
#pragma warning restore 0169

        static IntPtr id_getCode;
        public virtual unsafe int Code
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']/method[@name='getCode' and count(parameter)=0]"
            [Register("getCode", "()I", "GetGetCodeHandler")]
            get
            {
                if (id_getCode == IntPtr.Zero)
                    id_getCode = JNIEnv.GetMethodID(class_ref, "getCode", "()I");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return JNIEnv.CallIntMethod(this.Handle, id_getCode);
                    else
                        return JNIEnv.CallNonvirtualIntMethod(this.Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getCode", "()I"));
                }
                finally
                {
                }
            }
        }

        static Delegate cb_getMsg;
#pragma warning disable 0169
        static Delegate GetGetMsgHandler()
        {
            if (cb_getMsg == null)
                cb_getMsg = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetMsg);
            return cb_getMsg;
        }

        static IntPtr n_GetMsg(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Alipay.Android.Phone.Mrpc.Core.RpcException __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcException>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.NewString(__this.Msg);
        }
#pragma warning restore 0169

        static IntPtr id_getMsg;
        public virtual unsafe string Msg
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']/method[@name='getMsg' and count(parameter)=0]"
            [Register("getMsg", "()Ljava/lang/String;", "GetGetMsgHandler")]
            get
            {
                if (id_getMsg == IntPtr.Zero)
                    id_getMsg = JNIEnv.GetMethodID(class_ref, "getMsg", "()Ljava/lang/String;");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return JNIEnv.GetString(JNIEnv.CallObjectMethod(this.Handle, id_getMsg), JniHandleOwnership.TransferLocalRef);
                    else
                        return JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(this.Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getMsg", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        static Delegate cb_getOperationType;
#pragma warning disable 0169
        static Delegate GetGetOperationTypeHandler()
        {
            if (cb_getOperationType == null)
                cb_getOperationType = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetOperationType);
            return cb_getOperationType;
        }

        static IntPtr n_GetOperationType(IntPtr jnienv, IntPtr native__this)
        {
            global::Com.Alipay.Android.Phone.Mrpc.Core.RpcException __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcException>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            return JNIEnv.NewString(__this.OperationType);
        }
#pragma warning restore 0169

        static Delegate cb_setOperationType_Ljava_lang_String_;
#pragma warning disable 0169
        static Delegate GetSetOperationType_Ljava_lang_String_Handler()
        {
            if (cb_setOperationType_Ljava_lang_String_ == null)
                cb_setOperationType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_SetOperationType_Ljava_lang_String_);
            return cb_setOperationType_Ljava_lang_String_;
        }

        static void n_SetOperationType_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Alipay.Android.Phone.Mrpc.Core.RpcException __this = global::Java.Lang.Object.GetObject<global::Com.Alipay.Android.Phone.Mrpc.Core.RpcException>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            string p0 = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
            __this.OperationType = p0;
        }
#pragma warning restore 0169

        static IntPtr id_getOperationType;
        static IntPtr id_setOperationType_Ljava_lang_String_;
        public virtual unsafe string OperationType
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']/method[@name='getOperationType' and count(parameter)=0]"
            [Register("getOperationType", "()Ljava/lang/String;", "GetGetOperationTypeHandler")]
            get
            {
                if (id_getOperationType == IntPtr.Zero)
                    id_getOperationType = JNIEnv.GetMethodID(class_ref, "getOperationType", "()Ljava/lang/String;");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return JNIEnv.GetString(JNIEnv.CallObjectMethod(this.Handle, id_getOperationType), JniHandleOwnership.TransferLocalRef);
                    else
                        return JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(this.Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getOperationType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
            // Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']/method[@name='setOperationType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
            [Register("setOperationType", "(Ljava/lang/String;)V", "GetSetOperationType_Ljava_lang_String_Handler")]
            set
            {
                if (id_setOperationType_Ljava_lang_String_ == IntPtr.Zero)
                    id_setOperationType_Ljava_lang_String_ = JNIEnv.GetMethodID(class_ref, "setOperationType", "(Ljava/lang/String;)V");
                IntPtr native_value = JNIEnv.NewString(value);
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(native_value);

                    if (((object)this).GetType() == ThresholdType)
                        JNIEnv.CallVoidMethod(this.Handle, id_setOperationType_Ljava_lang_String_, __args);
                    else
                        JNIEnv.CallNonvirtualVoidMethod(this.Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "setOperationType", "(Ljava/lang/String;)V"), __args);
                }
                finally
                {
                    JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }

        static IntPtr id_format_Ljava_lang_Integer_Ljava_lang_String_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.alipay.android.phone.mrpc.core']/class[@name='RpcException']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
        [Register("format", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;", "")]
        protected static unsafe string Format(global::Java.Lang.Integer p0, string p1)
        {
            if (id_format_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
                id_format_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetStaticMethodID(class_ref, "format", "(Ljava/lang/Integer;Ljava/lang/String;)Ljava/lang/String;");
            IntPtr native_p1 = JNIEnv.NewString(p1);
            try
            {
                JValue* __args = stackalloc JValue[2];
                __args[0] = new JValue(p0);
                __args[1] = new JValue(native_p1);
                string __ret = JNIEnv.GetString(JNIEnv.CallStaticObjectMethod(class_ref, id_format_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
                JNIEnv.DeleteLocalRef(native_p1);
            }
        }

    }
}
