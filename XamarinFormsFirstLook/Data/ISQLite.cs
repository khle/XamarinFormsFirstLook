using SQLite;

namespace XamarinFormsFirstLook.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}