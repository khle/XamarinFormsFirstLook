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

	    private void DataBinding3_Clicked(object sender, EventArgs e)
	    {
	        throw new NotImplementedException();
	    }

	    private void List1_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new ListPage1());
		}

		private void Tab_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new TabContainer());
		}

		private void Style_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new StylePage());
		}

		private void DynamicStyle_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new DynamicStylePage());
		}

	    private void Trigger_Clicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new TriggerPage());
	    }

	    private void PubSub_Clicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new PubSubPage());
	    }

	    private void CustomButton_Clicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new CustomButton());
	    }

	    private void CustomBoxView_Clicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new CustomBoxView());
	    }

	    private void CustomExtension_Clicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new CustomMarkup());
	    }

	    private void PlatformService_Clicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new PlatformService());
	    }

	    private void List2_Clicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new ListPage2());
	    }
	}
}
