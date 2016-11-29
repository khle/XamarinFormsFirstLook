using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using XamarinFormsFirstLook.Data;
using XamarinFormsFirstLook.Droid;

[assembly: Dependency(typeof(SQLite_Android))]
namespace XamarinFormsFirstLook.Droid
{
    public class SQLite_Android : ISQLite
    {
        #region ISQLite implementation

        public SQLiteConnection GetConnection()
        {
            var dbFile = "Contacts.db";
            var privatePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(privatePath, dbFile);
            var connection = new SQLite.SQLiteConnection(path, true);
            return connection;
        }

        #endregion
    }
}