using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsFirstLook
{
	public partial class PubSubPage : ContentPage
	{
		public PubSubPage()
		{
			InitializeComponent();
		    Subscribe();
		}

	    private void Subscribe()
	    {
	        MessagingCenter.Subscribe<PubSubPage>(this, "fireEvent", (sender) =>
	        {
	            ButtonPubSub.Text = "Don't click!!";
	        });
	    }

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new PubPage());
	    }
	}
}
