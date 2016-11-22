using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsFirstLook.Models;

namespace XamarinFormsFirstLook
{
	public partial class DataBindingPage2 : ContentPage
	{
		DataBindingPage2ViewModel dbp2VM;

		public DataBindingPage2()
		{
			User user1 = DataBindingPage2ViewModel.GetUser();
			User user2 = DataBindingPage2ViewModel.GetUser2();

			dbp2VM = new DataBindingPage2ViewModel(user2);
			BindingContext = dbp2VM;

			InitializeComponent();
		}
	}
}
