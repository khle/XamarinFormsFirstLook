using System;
using XamarinFormsFirstLook.Model;

namespace XamarinFormsFirstLook
{
	public class DataBindingPage2ViewModel
	{
		public DataBindingPage2ViewModel(User user)
		{
			FullName = user.FirstName + " " + user.LastName;
			Age = GetAge(user.Age);
			Password = user.Password.Length == 0 ? "<Set password>" : "******";
		}

		string GetAge(int Age)
		{
			if (Age < 18) return Age + "(Child)";
			if (Age < 30) return Age + "(Young)";
			if (Age < 50) return Age + "(Adult)";
			else return Age + "(Old)";
		}

		public string FullName { get; set; }
		public string Age { get; set; }
		public string Password { get; set; }

		public static User GetUser()
		{
			return new User()
			{
				FirstName = "John",
				LastName = "Doe",
				Age = 25,
				Password = "Jonny"

			};
		}

		public static User GetUser2()
		{
			return new User()
			{
				FirstName = "Sarah",
				LastName = "Doe",
				Age = 65,
				Password = ""
			};
		}

	}
}
