using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
	public partial class DataBindingPage1 : ContentPage
	{
		public DataBindingPage1()
		{
			BindingContext = GetUser();
			InitializeComponent();
		}

		private User GetUser()
		{
			return new User
			{
				FirstName = "John",
				LastName = "Doe",
				Age = 25
			};
		}
	}
}
