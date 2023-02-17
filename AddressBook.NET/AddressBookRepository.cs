using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBook.NET
{
    internal class AddressBookRepository
    {
        public static string connection = @"Server=(localdb)\ProjectModels;Database=Book;Trusted_Connection=True;";
        SqlConnection sqlConnection = new SqlConnection(connection);
    }
}
