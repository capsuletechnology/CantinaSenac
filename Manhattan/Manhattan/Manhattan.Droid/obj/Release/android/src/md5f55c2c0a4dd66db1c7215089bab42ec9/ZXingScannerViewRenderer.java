package md5f55c2c0a4dd66db1c7215089bab42ec9;


public class ZXingScannerViewRenderer
	extends md5b60ffeb829f638581ab2bb9b1a7f4f3f.ViewRenderer_2
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("ZXing.Net.Mobile.Forms.Android.ZXingScannerViewRenderer, ZXing.Net.Mobile.Forms.Android, Version=2.1.47.0, Culture=neutral, PublicKeyToken=null", ZXingScannerViewRenderer.class, __md_methods);
	}


	public ZXingScannerViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == ZXingScannerViewRenderer.class)
			mono.android.TypeManager.Activate ("ZXing.Net.Mobile.Forms.Android.ZXingScannerViewRenderer, ZXing.Net.Mobile.Forms.Android, Version=2.1.47.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ZXingScannerViewRenderer (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == ZXingScannerViewRenderer.class)
			mono.android.TypeManager.Activate ("ZXing.Net.Mobile.Forms.Android.ZXingScannerViewRenderer, ZXing.Net.Mobile.Forms.Android, Version=2.1.47.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public ZXingScannerViewRenderer (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ZXingScannerViewRenderer.class)
			mono.android.TypeManager.Activate ("ZXing.Net.Mobile.Forms.Android.ZXingScannerViewRenderer, ZXing.Net.Mobile.Forms.Android, Version=2.1.47.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

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
