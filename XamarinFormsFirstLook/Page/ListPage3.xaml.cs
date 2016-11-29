using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using XamarinFormsFirstLook.Data;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
	public partial class ListPage3 : ContentPage
	{
	    public ObservableCollection<Grouping<string,Contact>> ContactGroup;

	    public ListPage3() {
	        Init();
	        BindingContext = ContactGroup;
	        InitializeComponent();
	    }

	    private void Init()
	    {
	        var listOfContacts = DataGenerator.GetObservableContacts();

	        var sorted =
	            from c in listOfContacts
	            orderby c.FirstName
	            group c by c.FirstName[0].ToString()
	            into theGroup
	            select new Grouping<string, Contact>(theGroup.Key, theGroup);

	        ContactGroup = new ObservableCollection<Grouping<string,Contact>>(sorted);
	    }

	    private void OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        var contact = e.Item as Contact;
	        DisplayAlert("Great!", contact.FirstName + " " + contact.LastName, "OK");
	    }
	}
}
