using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
	public partial class ContactEntryPage : ContentPage
	{
	    private int updateID = 0;

	    public ContactEntryPage() {
			InitializeComponent();
		}

	    public ContactEntryPage(int id)
	    {
	        InitializeComponent();
	        var contact = App.Database.GetContect(id);
	        FirstName.Text = contact.FirstName;
	        LastName.Text = contact.LastName;
	        Email.Text = contact.Email;
	        IsFavorite.IsToggled = contact.IsFavorite;
	        updateID = id;
	    }

	    public void OnSave(object o, EventArgs e) {
	        Contact contact = new Contact();
	        contact.FirstName = FirstName.Text;
	        contact.LastName = LastName.Text;
	        contact.Email = Email.Text;
	        contact.IsFavorite = IsFavorite.IsToggled;
	        contact.ID = updateID;
	        Clear();
	        App.Database.SaveContact(contact);
	        Navigation.PopAsync(true);
	    }

	    private void OnCancel(object o, EventArgs e) {
	        Clear();
	    }

	    private void OnReview(object o, EventArgs e) {
	        Navigation.PopAsync(true);
	    }

	    private void Clear() {
	        FirstName.Text = LastName.Text = Email.Text = string.Empty;
	        IsFavorite.IsToggled = false;
	    }
	}
}
