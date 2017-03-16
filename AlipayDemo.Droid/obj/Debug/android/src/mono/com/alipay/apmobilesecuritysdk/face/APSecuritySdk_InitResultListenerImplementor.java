package mono.com.alipay.apmobilesecuritysdk.face;


public class APSecuritySdk_InitResultListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.alipay.apmobilesecuritysdk.face.APSecuritySdk.InitResultListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onResult:(Lcom/alipay/apmobilesecuritysdk/face/APSecuritySdk$TokenResult;)V:GetOnResult_Lcom_alipay_apmobilesecuritysdk_face_APSecuritySdk_TokenResult_Handler:Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk/IInitResultListenerInvoker, AlipayBindingDemo\n" +
			"";
		mono.android.Runtime.register ("Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk+IInitResultListenerImplementor, AlipayBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", APSecuritySdk_InitResultListenerImplementor.class, __md_methods);
	}


	public APSecuritySdk_InitResultListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == APSecuritySdk_InitResultListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Alipay.Apmobilesecuritysdk.Face.APSecuritySdk+IInitResultListenerImplementor, AlipayBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onResult (com.alipay.apmobilesecuritysdk.face.APSecuritySdk.TokenResult p0)
	{
		n_onResult (p0);
	}

	private native void n_onResult (com.alipay.apmobilesecuritysdk.face.APSecuritySdk.TokenResult p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
