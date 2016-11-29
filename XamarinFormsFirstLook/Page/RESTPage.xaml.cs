using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsFirstLook
{
	public partial class RESTPage : ContentPage
	{
	    RESTViewModel vm;

	    public RESTPage() {
	        vm = new RESTViewModel();
	        BindingContext = vm;
	        InitializeComponent();
		}

	    private async void OnClicked(object sender, EventArgs e)
	    {
	        var longitude = double.Parse(Lon.Text);
	        var latitude = double.Parse(Lat.Text);

	        //var url = string.Format("http://api.geonames.org/findNearByWeatherJSON?lat={0}&lng={1}&username=jesseliberty", latitude, longitude);
	        var url = string.Format("http://api.geonames.org/findNearByWeatherJSON?lat={0}&lng={1}&username=tausiq", latitude, longitude);
	        await vm.GetWeatherAsync(url);
	    }
	}
}
