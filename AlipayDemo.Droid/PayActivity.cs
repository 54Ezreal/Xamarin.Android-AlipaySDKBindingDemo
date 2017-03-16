using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading;
using Com.Alipay.Sdk.App;

namespace AlipayDemo.Droid
{
    [Activity(Label = "AlipayDemo.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class PayActivity : Activity
    {
        public static string PARTNER = "2017031506227928";
        public static string SELLER = "";//商户收款的支付宝账号
        string RSA_PRIVATE = "MIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQCcoUuOkRqYpyWbq/E8I4TLjAcabujagLT46YBFwtMhJm6/93hvk/BZwq/w2vu4UbPqFHaYmw58F89Hzm4yXmj8oogQJhyLOauZbVkK9+UlUAq13xDLExd9BCxGD0d6mBk/XulF+NPQqhgbkbg2c9s8F2fO/wDLbhdJCUEBmJwCM7MVvLnJlRTe17CwxWYjOJaaNN8YLSi/MFzDIF8NBZqFdF9QkW490seO7po7EBSg8GgglxL1Hds+/FDc7M+JcG4f3xEIh26OhxPZcJH7xnzxFWl/Yjs4Q4jRtS4AjD9aEruPJ8krFynzxJo/9JPBqP7DJ9mBV6ulEH/uYjhsoFXfAgMBAAECgf8GHkbVStW/IMhXTGAf+UM2sEGWxr5RyrVHA9f+4Z1driKlXQVXVnANEY3N2r/6czaT7jizvVrTfhqas3WaghWXyMGH3/U9ewM4+wx/YS+SRY4ljJEbXaONPpx8IByqrUZPM2XpVc7wV7SZXxfTCLOHpWJos41UZPiD4dioN03gyBSR50JbG8AKqcFJ4MyAi9R21BuKpsMo4xtCiApOylwR89ZJMuujcsHx3euBCdHezm577144P6pEfZgTQ/GOmw2W1zkveigy6ca+EskuNzmczZ6lRgxY2/avgPCX/6vDD/pWacSqX4VE/oBZaCQ5msfs+TfNlwjnfAXYEsiaEDECgYEAyIMB4FYcDxXMfozHlyiLdmvul4mNiCbxhXPjZDvGZgOCd4mm/8bNv9KJ/RYI+2UOnPzo5PxDcRizAn4h5gDD4LArZWj9yyniQ2evaHyu3FtSDKl0tlDO4J4Zu20ayZAMmVHjoxA+pGxQsuRBLrm9odL/EVf0uCTRya3t58JuYg0CgYEAx/mMBgOpgfGqAC1h+HHX0x1q165kpW4E04u1S7v660bBFN+YWQcuF0YBrT+yAfim3U1+w5xDw1WADK8w1Hqc7tjSEVpnRUk/DHWaCWVzpPtwniV1W2nTGkE+o0g3e+pzMZmn10ptW3pGkcRzoagEz1zYTeGAs6Ym+qRkP2FQ2JsCgYEAt3Icall9zFNeRz2XcXUXux1eKWggg7tVZoozNUX26ug1GhZnIkWJggEmW9UoHJBFgV1l2fHt5e/5/sLVUq/KhavH2DzpTVGhf5fCBG9mL5ahB5KVhCOEUj5zPmXAhz5yOGeSQ2KeXSH35uMru4sVspLu57g33a1Z/hFRwqLBCJUCgYAWTJF8qjPgtZ4LXwQpvCgg9orPejbm65nGLTIOO+wDCGTHexd19gMBvWC6fPvQlHWm/9k+3tH/mi0pPO/pAbM2Px9NqBMT+tL5BLQkkBeRMiigufSYOPi9WMEvXAIz4zTtNwEsVLRVGxF7d7idMis3JFdKd/buEX0PPf2fw65MOQKBgQC/QPKmyhJlWj7ryk9o8+7FCYpccRZttmN4srL0DaGX/U4AniLFy3Uh16v2xgJAZmWtZyvfgqha1SXYeRs8BRDrBa26qvQKnIE0d4aE6pMTFOCarSMBCJReKSMy4j1/UN12GPg8jXZ8yKyrPX88EnKLSWfc5LBE5GBcEEhLMDZRtg=="; //商户密钥


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Pay);

            PayTask payTask = new PayTask(this);
            Toast.MakeText(this, payTask.Version, ToastLength.Long).Show();

            var btn = FindViewById<Button>(Resource.Id.btnPay);

            btn.Click += btn_Click;

        }
        void Logger_Info(string msg)
        {
            using (System.IO.StreamWriter srFile = new System.IO.StreamWriter("/sdcard/zzl.txt", true))
            {
                srFile.WriteLine(string.Format("{0}{1}{2}"
                    , DateTime.Now.ToString().PadRight(20)
                    , ("[ThreadID:" + Thread.CurrentThread.ManagedThreadId.ToString() + "]").PadRight(14)
                    , msg));
                srFile.Close();
                srFile.Dispose();
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                System.Threading.Thread the = new System.Threading.Thread(Pay);
                the.Start();

            }
            catch (Exception ex)
            {
                Logger_Info("1" + ex.Message);
            }
        }

        private void Pay()
        {
            try
            {
                var con = getOrderInfo("test", "testbody");
                var sign = SignatureUtils.Sign(con, RSA_PRIVATE);
                sign = Java.Net.URLEncoder.Encode(sign, "utf-8");
                con += "&sign=\"" + sign + "\"&" + MySignType;
                PayTask pa = new PayTask(this);
                var result = pa.Pay(con, false);
                Logger_Info("支付宝result:" + result);
            }
            catch (Exception ex)
            {

                Logger_Info("2" + ex.Message + ex.StackTrace);
            }

        }

        #region 组合

        public String getOrderInfo(String subject, String body)
        {
            // 签约合作者身份ID
            String orderInfo = "partner=" + "\"" + PARTNER + "\"";
            // 签约卖家支付宝账号
            orderInfo += "&seller_id=" + "\"" + SELLER + "\"";
            // 商户网站唯一订单号
            orderInfo += "&out_trade_no=" + "\"DJ" + DateTime.Now.ToString("yyyyMMddhhmmss") + "\"";
            // 商品名称
            orderInfo += "&subject=" + "\"" + subject + "\"";
            // 商品详情
            orderInfo += "&body=" + "\"" + body + "\"";
            // 商品金额
            orderInfo += "&total_fee=" + "\"" + 1 + "\"";
            // 服务器异步通知页面路径
            orderInfo += "&notify_url=" + "\"" + "www.huuncle.com"
                    + "\"";
            // 服务接口名称， 固定值
            orderInfo += "&payment_type=\"1\"";

            // 参数编码， 固定值

            orderInfo += "&_input_charset=\"utf-8\"";

            // 设置未付款交易的超时时间

            // 默认30分钟，一旦超时，该笔交易就会自动被关闭。

            // 取值范围：1m～15d。

            // m-分钟，h-小时，d-天，1c-当天（无论交易何时创建，都在0点关闭）。

            // 该参数数值不接受小数点，如1.5h，可转换为90m。
            orderInfo += "&it_b_pay=\"30m\"";

            // extern_token为经过快登授权获取到的alipay_open_id,带上此参数用户将使用授权的账户进行支付

            // orderInfo += "&extern_token=" + "\"" + extern_token + "\"";

            // 支付宝处理完请求后，当前页面跳转到商户指定页面的路径，可空

            orderInfo += "&return_url=www.huuncle";

            // 调用银行卡支付，需配置此参数，参与签名， 固定值 （需要签约《无线银行卡快捷支付》才能使用）

            // orderInfo += "&paymethod=\"expressGateway\"";

            return orderInfo;

        }

        public String MySignType
        {
            get
            {
                return "sign_type=\"RSA\"";
            }
        }

        #endregion


    }
}

