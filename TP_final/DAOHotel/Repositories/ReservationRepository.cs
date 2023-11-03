using DAOHotel.Interfaces;
using DAOHotel.Models;
using DAOHotel.Tools;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DAOHotel.Repositories
{
    public class ReservationRepository : BaseRepository, IRepository<Reservation>
    {
        public void Create(Reservation element)
        {
            connection = Connection.New;
            connection.Open();
            MySqlTransaction transaction = connection.BeginTransaction();
            try
            {
                request = "INSERT INTO reservation (customer_id, status) values (@customer_id, @status); SELECT LAST_INSERT_ID();";
                command = new MySqlCommand(request, connection, transaction);
                command.Parameters.AddWithValue("@customer_id", element.Customer.Id);
                command.Parameters.AddWithValue("@status", element.Status);
                int reservation_id = Convert.ToInt32(command.ExecuteScalar());
                command.Dispose();

                foreach (Room c in element.Rooms)
                {
                    request = "INSERT INTO reservation_room (room_id, reservation_id) values (@room_id, @reservation_id);" +
                        "UPDATE room set status = @status where id=@room_id;";
                    command = new MySqlCommand(request, connection, transaction);
                    command.Parameters.AddWithValue("@room_id", c.Id);
                    command.Parameters.AddWithValue("@reservation_id", reservation_id);
                    command.Parameters.AddWithValue("@status", c.Status);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                element.Id = reservation_id;
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw; // Consider rethrowing the exception or logging it.
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Reservation> FindAll()
        {
            List<Reservation> reservations = new List<Reservation>();
            request = "SELECT r.id, r.status, c.id, c.firstname, c.lastname, c.phone from " +
                "reservation as r inner join customer as c on c.id = r.customer_id";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Reservation r = new Reservation()
                {
                    Id = reader.GetInt32(0),
                    Status = (ReservationStatus)reader.GetInt32(1),
                    Customer = new Customer()
                    {
                        Id = reader.GetInt32(2),
                        FirstName = reader.GetString(3),
                        LastName = reader.GetString(4),
                        Phone = reader.GetString(5),
                    }
                };
                reservations.Add(r);
            }
            reader.Close();
            connection.Close();
            return reservations;
        }

        public Reservation FindById(int id)
        {
            Reservation reservation = null;
            request = "SELECT r.id, r.status, c.id, c.firstname, c.lastname, c.phone from " +
                "reservation as r inner join customer as c on c.id = r.customer_id where r.id = @id";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                reservation = new Reservation()
                {
                    Id = reader.GetInt32(0),
                    Status = (ReservationStatus)reader.GetInt32(1),
                    Customer = new Customer()
                    {
                        Id = reader.GetInt32(2),
                        FirstName = reader.GetString(3),
                        LastName = reader.GetString(4),
                        Phone = reader.GetString(5),
                    }
                };
            }
            reader.Close();
            connection.Close();
            return reservation;
        }

        public bool Update(Reservation element)
        {
            bool result = false;
            connection = Connection.New;
            connection.Open();
            MySqlTransaction transaction = connection.BeginTransaction();
            try
            {
                request = "UPDATE reservation set status = @status where id = @id";
                command = new MySqlCommand(request, connection, transaction);
                command.Parameters.AddWithValue("@id", element.Id);
                command.Parameters.AddWithValue("@status", element.Status);
                int nbRow = command.ExecuteNonQuery();
                command.Dispose();
                foreach (Room c in element.Rooms)
                {
                    request = "UPDATE room set status = @status where id=@room_id;";
                    command = new MySqlCommand(request, connection, transaction);
                    command.Parameters.AddWithValue("@room_id", c.Id);
                    command.Parameters.AddWithValue("@status", c.Status);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                transaction.Commit();
                result = nbRow == 1;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw; // Consider rethrowing the exception or logging it.
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public bool Delete(Reservation element)
        {
            throw new NotImplementedException();
        }
    }
}
