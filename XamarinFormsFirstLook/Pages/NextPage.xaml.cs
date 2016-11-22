using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsFirstLook
{
	public partial class NextPage : ContentPage
	{
		public NextPage()
		{
			InitializeComponent();
		}

		private void GoBack_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}
