using Xamarin.Forms;
using XamarinFormsFirstLook.Data;

namespace XamarinFormsFirstLook
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new XamarinFormsFirstLookPage());
		}

	    static ContactDatabase database;

	    public static ContactDatabase Database {
	        get {
	            if (database == null) {
	                database = new ContactDatabase();
	            }
	            return database;
	        }
	    }

	    protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
