using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAOHotel.Repositories
{
    using MySql.Data.MySqlClient;

    public class BaseRepository
    {
        protected MySqlCommand command;
        protected MySqlDataReader reader;
        protected string request;
        protected MySqlConnection connection;
    }

}
