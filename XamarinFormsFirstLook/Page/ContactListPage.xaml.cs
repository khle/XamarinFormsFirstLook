using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
	public partial class ContactListPage : ContentPage
	{
		public ContactListPage() {
			InitializeComponent();
		}

	    public void OnItemTapped(object o, ItemTappedEventArgs e) {
	        var contact = e.Item as Contact;
	        Navigation.PushAsync(new ContactEntryPage(contact.ID));
	    }

	    protected override void OnAppearing() {
	        base.OnAppearing();
	        ContactList.ItemsSource = App.Database.GetContacts();
	    }

	    protected void OnNewEntry(object o, EventArgs e) {
	        Navigation.PushAsync(new ContactEntryPage());
	    }
	}
}
