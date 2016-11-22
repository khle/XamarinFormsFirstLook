using System;
using Xamarin.Forms;

namespace XamarinFormsFirstLook
{
	public partial class XamarinFormsFirstLookPage : ContentPage
	{
		public XamarinFormsFirstLookPage()
		{
			InitializeComponent();
		}

		private void Submit_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("Greetings!", "Hello from Xamarin.Forms!", "OK");
		}

		private void NextPage_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new NextPage());
		}

		private void DataBinding1_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DataBindingPage1());
		}

		private void DataBinding2_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DataBindingPage2());
		}

	    private void List1_Clicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new ListPage1());
	    }


	}
}
