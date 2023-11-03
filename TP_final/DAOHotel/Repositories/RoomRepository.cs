using DAOHotel.Interfaces;
using DAOHotel.Models;
using DAOHotel.Tools;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DAOHotel.Repositories
{
    public class RoomRepository : BaseRepository, IRepository<Room>
    {
        public void Create(Room element)
        {
            request = "INSERT INTO room (price, max, status) VALUES (@price, @max, @status); SELECT LAST_INSERT_ID();";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@price", element.Price));
            command.Parameters.Add(new MySqlParameter("@max", element.Max));
            command.Parameters.Add(new MySqlParameter("@status", element.Status));
            connection.Open();
            element.Id = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            connection.Close();
        }

        public bool Delete(Room element)
        {
            request = "DELETE FROM room WHERE id=@id";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", element.Id));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }

        public List<Room> FindAll()
        {
            List<Room> rooms = new List<Room>();
            request = "SELECT id, price, max, status FROM room";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Room r = new Room()
                {
                    Id = reader.GetInt32(0),
                    Price = reader.GetDecimal(1),
                    Max = reader.GetInt32(2),
                    Status = (RoomStatus)reader.GetInt32(3)
                };
                rooms.Add(r);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return rooms;
        }

        public List<Room> FindAllByStatus(RoomStatus status)
        {
            List<Room> rooms = new List<Room>();
            request = "SELECT id, price, max, status FROM room WHERE status=@status";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@status", status));
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Room r = new Room()
                {
                    Id = reader.GetInt32(0),
                    Price = reader.GetDecimal(1),
                    Max = reader.GetInt32(2),
                    Status = (RoomStatus)reader.GetInt32(3)
                };
                rooms.Add(r);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return rooms;
        }

        public List<Room> FindAllByReservationId(int id)
        {
            List<Room> rooms = new List<Room>();
            request = "SELECT r.id, r.price, r.max, r.status FROM room AS r " +
                "INNER JOIN reservation_room AS rr ON r.id = rr.room_id WHERE rr.reservation_id=@id";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", id));
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Room r = new Room()
                {
                    Id = reader.GetInt32(0),
                    Price = reader.GetDecimal(1),
                    Max = reader.GetInt32(2),
                    Status = (RoomStatus)reader.GetInt32(3)
                };
                rooms.Add(r);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return rooms;
        }

        public Room FindById(int id)
        {
            Room room = null;
            request = "SELECT id, price, max, status FROM room WHERE id=@id";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", id));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                room = new Room()
                {
                    Id = reader.GetInt32(0),
                    Price = reader.GetDecimal(1),
                    Max = reader.GetInt32(2),
                    Status = (RoomStatus)reader.GetInt32(3)
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return room;
        }

        public bool Update(Room element)
        {
            request = "UPDATE room SET status=@status WHERE id=@id";
            connection = Connection.New;
            command = new MySqlCommand(request, connection);
            command.Parameters.Add(new MySqlParameter("@id", element.Id));
            command.Parameters.Add(new MySqlParameter("@status", element.Status));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }
    }
}
