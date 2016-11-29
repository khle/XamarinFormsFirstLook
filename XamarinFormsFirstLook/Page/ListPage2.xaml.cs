using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xamarin.Forms;
using XamarinFormsFirstLook.Data;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
	public partial class ListPage2 : ContentPage
	{
	    public List<Contact> Contacts { get; set; }
	    
	    public ListPage2()
	    {
	        Init();
		}

	    private void Init()
	    {
            Contacts = DataGenerator.GetContacts();
            BindingContext = this;
            InitializeComponent();
	    }

	    private void OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
            var contact = e.Item as Contact;
			DisplayAlert("Great!", contact.FirstName + " " + contact.LastName, "OK");
	    }
	}
}
