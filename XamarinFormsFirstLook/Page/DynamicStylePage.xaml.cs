using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsFirstLook
{
	public partial class DynamicStylePage : ContentPage
	{
	    private bool shouldDisplayTime;

		public DynamicStylePage()
		{
			InitializeComponent();
		}

	    protected override void OnAppearing()
	    {
	        shouldDisplayTime = true;
	        Device.StartTimer( TimeSpan.FromSeconds(1), () =>
	        {
	            Resources["currentTime"] = DateTime.Now.ToString();
	            return shouldDisplayTime;
	        });
	        base.OnAppearing();

	    }

	    protected override void OnDisappearing()
	    {
	        shouldDisplayTime = false;
	        base.OnDisappearing();
	    }
	}
}
