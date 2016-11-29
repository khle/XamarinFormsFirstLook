using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XamarinFormsFirstLook.Data;
using XamarinFormsFirstLook.iOS;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace XamarinFormsFirstLook.iOS
{
    public class SQLite_IOS: ISQLite
    {
        public SQLite_IOS()
        {
        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Contacts.db";
            //			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
            //			string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
            //			var path = Path.Combine(libraryPath, sqliteFilename);

            var path = "/users/shahab/Contacts.db";

            // This is where we copy in the prepopulated database
            if (!File.Exists(path))
            {
                File.Copy(sqliteFilename, path);
            }

            var conn = new SQLite.SQLiteConnection(path);

            // Return the database connection
            return conn;
        }
    }
}