using System;
using System.Collections.Generic;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
	public class ListPage1ViewModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Age { get; set; }


		public ListPage1ViewModel()
		{
		}

		public List<User> Users()
		{
			return new List<User>()
			{
				new User() {FirstName = "John", LastName = "Doe", Age = 25},
				new User() {FirstName = "Sarah", LastName = "Doe", Age = 58},
				new User() {FirstName = "Andrew", LastName = "Phillips", Age = 35}
			};

		}
	}
}
