using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
	public partial class ListPage4 : ContentPage
	{
	    ListPage4ViewModel vm;

	    public ListPage4() {
	        vm = new ListPage4ViewModel();
	        BindingContext = vm;
	        InitializeComponent();
		}

	    private void OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        var contact = e.Item as Contact;
	        DisplayAlert("Great!", contact.FirstName + " " + contact.LastName, "OK");
	    }
	}
}
