using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAOHotel.Tools
{
    class Connection
    {
        private static string stringConnection = @"Server=localhost;Database=hotel_db;User ID=root;Password=admin;";

        public static MySqlConnection New
        {
            get => new MySqlConnection(stringConnection);
        }
    }
}
