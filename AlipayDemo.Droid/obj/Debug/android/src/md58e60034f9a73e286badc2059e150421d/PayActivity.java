package md58e60034f9a73e286badc2059e150421d;


public class PayActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AlipayDemo.Droid.PayActivity, AlipayDemo.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", PayActivity.class, __md_methods);
	}


	public PayActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == PayActivity.class)
			mono.android.TypeManager.Activate ("AlipayDemo.Droid.PayActivity, AlipayDemo.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
