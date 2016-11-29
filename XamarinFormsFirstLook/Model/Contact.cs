using System;
using SQLite;

namespace XamarinFormsFirstLook.Model
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Boolean IsFavorite { get; set; }
    }
}