using DemoMVVM.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.Repositories
{
   public class PersonRepository
    {

        private MySqlCommand command;
        private MySqlConnection _connection;
        private MySqlDataReader reader;
        private string request;

       public PersonRepository(MySqlConnection connection)
        {
            _connection = connection;
        }
           
        public Person Create(Person person)
        {
            request = "INSERT INTO person(firstname, lastname)values(@firstname, @lastname);SELECT LAST_INSERT_ID();";

            if(_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();

            }
            command = new MySqlCommand(request, _connection);
            command.Parameters.Add(new MySqlParameter("@firstname", person.FirstName));
            command.Parameters.Add(new MySqlParameter("@lastname", person.LastName));

            person.Id = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();

            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();

            }
            return person;
        }

        public List<Person> FindAll()
        {
            List<Person> list = new List<Person>();
            request = "SELECT id, firstname, lastname from person";
            command = new MySqlCommand(request, _connection);

            _connection.Open();

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Person person = new Person()
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2)
                };

                list.Add(person);

            }
            reader.Close(); 
            command.Dispose();
            _connection.Close();
            return list;
        }




    }
}
