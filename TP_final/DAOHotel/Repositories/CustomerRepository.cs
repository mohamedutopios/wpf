using MySql.Data.MySqlClient;
using DAOHotel.Interfaces;
using DAOHotel.Models;
using DAOHotel.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAOHotel.Repositories
{
    public class CustomerRepository : BaseRepository, IRepository<Customer>
    {

        public void Create(Customer element)
        {
            if (element != null)
            {
                request = "INSERT INTO customer (firstname, lastname, phone) values (@firstname, @lastname, @phone)";
                connection = Connection.New;
                command = new MySqlCommand(request, connection);
                command.Parameters.Add(new MySqlParameter("@firstname", element.FirstName));
                command.Parameters.Add(new MySqlParameter("@lastname", element.LastName));
                command.Parameters.Add(new MySqlParameter("@phone", element.Phone));
                connection.Open();
                command.ExecuteNonQuery();
                element.Id = Convert.ToInt32(command.LastInsertedId);
                command.Dispose();
                connection.Close();
            }
        }

        public bool Delete(Customer element)
        {
            //request = "DELETE FROM customer where id=@id";
            //connection = Connection.New;
            //command = new MySqlCommand(request, connection);
            //command.Parameters.Add(new MySqlParameter("@id", element.Id));
            //connection.Open();
            //int nbRow = command.ExecuteNonQuery();
            //command.Dispose();
            //connection.Close();
            //return nbRow == 1;

           
            connection = Connection.New;
            connection.Open();

            // 1. Supprime d'abord les entrées associées dans la table reservation_room
            string deleteReservationRoomsRequest = "DELETE rr FROM reservation_room rr INNER JOIN reservation r ON rr.reservation_id = r.id WHERE r.customer_id=@id";
            MySqlCommand deleteReservationRoomsCommand = new MySqlCommand(deleteReservationRoomsRequest, connection);
            deleteReservationRoomsCommand.Parameters.Add(new MySqlParameter("@id", element.Id));
            deleteReservationRoomsCommand.ExecuteNonQuery();
            deleteReservationRoomsCommand.Dispose();

            // 2. Puis supprime toutes les réservations associées au client
            string deleteReservationsRequest = "DELETE FROM reservation WHERE customer_id=@id";
            MySqlCommand deleteReservationsCommand = new MySqlCommand(deleteReservationsRequest, connection);
            deleteReservationsCommand.Parameters.Add(new MySqlParameter("@id", element.Id));
            deleteReservationsCommand.ExecuteNonQuery();
            deleteReservationsCommand.Dispose();

            // 3. Finalement, supprime le client
            string deleteCustomerRequest = "DELETE FROM customer WHERE id=@id";
            MySqlCommand deleteCustomerCommand = new MySqlCommand(deleteCustomerRequest, connection);
            deleteCustomerCommand.Parameters.Add(new MySqlParameter("@id", element.Id));
            int nbRow = deleteCustomerCommand.ExecuteNonQuery();
            deleteCustomerCommand.Dispose();

            connection.Close();
            return nbRow == 1;

        }

        public List<Customer> FindAll()
        {
            List<Customer> customers = new List<Customer>();
            request = "SELECT id, firstname, lastname, phone from customer";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Customer c = new Customer()
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Phone = reader.GetString(3)
                };
                customers.Add(c);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return customers;
        }

        public Customer FindById(int id)
        {
            Customer customer = null;
            request = "SELECT id, firstname, lastname, phone from customer where id = @id";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            connection.Open();
            command.Parameters.Add(new MySqlParameter("@id", id));
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                customer = new Customer()
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Phone = reader.GetString(3)
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return customer;
        }

        public bool Update(Customer element)
        {
            throw new NotImplementedException();
        }
    }
}
