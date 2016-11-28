using System;

using Xamarin.Forms;

namespace XamarinFormsFirstLook
{
	public class GLabBoxView : BoxView
	{
		public static readonly BindableProperty BorderColorProperty = BindableProperty.Create<GLabBoxView, Color>(
		    p => p.BorderColor, default(Color)
		);

	    public Color BorderColor
	    {
	        get { return (Color) GetValue(BorderColorProperty); }
	        set { SetValue(BorderColorProperty, value);}
	    }

	    public static readonly BindableProperty BorderThicknessProperty = BindableProperty.Create<GLabBoxView, double>(
	        p => p.BorderThickness, default(double)
	    );

	    public double BorderThickness
	    {
	        get { return (double) GetValue(BorderThicknessProperty); }
	        set { SetValue(BorderThicknessProperty, value);}
	    }
	}
}

