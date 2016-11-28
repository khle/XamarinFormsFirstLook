using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsFirstLook
{
	public partial class CustomButton : ContentPage
	{
		public CustomButton() {
			InitializeComponent();
		}

		private void OnClickHandler(object sender, EventArgs e) {
			DisplayAlert("Hello", "Nice Button", "OK");
		}
	}
}
