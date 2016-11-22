using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
	public partial class ListPage1 : ContentPage
	{
		private ListPage1ViewModel vm;

		public ListPage1()
		{

			InitializeComponent();
			vm = new ListPage1ViewModel();
			UserListView.ItemsSource = vm.Users();
		}

		private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			User user = e.SelectedItem as User;
			DisplayAlert("User selected", user.FirstName, "OK");
		}
	}
}
