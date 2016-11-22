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
	}
}
