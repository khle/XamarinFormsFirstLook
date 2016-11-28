using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsFirstLook.Extension;

namespace XamarinFormsFirstLook
{
	public partial class PlatformService : ContentPage
	{
		public PlatformService() {
			InitializeComponent();
		}

		private void onClickTwitter(object sender, EventArgs e) {
			DependencyService.Get<ITwitter>().SendTweet("Hello world!!");
		}
	}
}
