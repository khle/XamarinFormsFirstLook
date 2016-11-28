using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsFirstLook
{
	public partial class PubPage : ContentPage
	{
		public PubPage() {
			InitializeComponent();
		}

		private void Button_OnClicked(object sender, EventArgs e) {
			MessagingCenter.Send<PubSubPage>(new PubSubPage(), "fireEvent");
			Navigation.PopAsync();
		}
	}
}
