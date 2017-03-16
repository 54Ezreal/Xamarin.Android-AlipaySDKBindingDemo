package mono.com.ta.utdid2.core.persistent;


public class MySharedPreferences_OnSharedPreferenceChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.ta.utdid2.core.persistent.MySharedPreferences.OnSharedPreferenceChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSharedPreferenceChanged:(Lcom/ta/utdid2/core/persistent/MySharedPreferences;Ljava/lang/String;)V:GetOnSharedPreferenceChanged_Lcom_ta_utdid2_core_persistent_MySharedPreferences_Ljava_lang_String_Handler:Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListenerInvoker, AlipayBindingDemo\n" +
			"";
		mono.android.Runtime.register ("Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListenerImplementor, AlipayBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MySharedPreferences_OnSharedPreferenceChangeListenerImplementor.class, __md_methods);
	}


	public MySharedPreferences_OnSharedPreferenceChangeListenerImplementor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MySharedPreferences_OnSharedPreferenceChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.TA.Utdid2.Core.Persistent.IMySharedPreferencesOnSharedPreferenceChangeListenerImplementor, AlipayBindingDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onSharedPreferenceChanged (com.ta.utdid2.core.persistent.MySharedPreferences p0, java.lang.String p1)
	{
		n_onSharedPreferenceChanged (p0, p1);
	}

	private native void n_onSharedPreferenceChanged (com.ta.utdid2.core.persistent.MySharedPreferences p0, java.lang.String p1);

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
