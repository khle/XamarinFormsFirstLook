using System.Collections.Generic;
using XamarinFormsFirstLook.Data;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
    public class ListPage4ViewModel
    {
        public List<Contact> Contacts { get; set; }

        public ListPage4ViewModel()
        {
            Contacts = new List<Contact>();
            var listOfContacts = DataGenerator.GetContacts();
            Contacts = listOfContacts;

        }
    }
}