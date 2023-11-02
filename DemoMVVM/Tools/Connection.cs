using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Tools
{
    public class Connection
    {
        private static string connectionString = "Server=localhost;Database=wpf_demo;User Id=root;Password=admin";

        public static MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }
}
