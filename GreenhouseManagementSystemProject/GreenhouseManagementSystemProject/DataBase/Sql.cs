using GreenhouseManagmentSystem.Enums;
using GreenhouseManagmentSystem.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GreenhouseManagmentSystem.DataBase
{
    public static class Sql
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Greenhouse;Integrated Security=True";

        public static bool Login(string userName, string password)
        {
            string query = $"SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password;";
            User user = null;

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                user = new User()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    UserName = reader.GetString(reader.GetOrdinal("UserName")),
                                    Password = reader.GetString(reader.GetOrdinal("Password")),
                                };
                            }
                            connection.Close();
                        }
                    }
                }
                return user != null;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddUser(string userName, string password, string email)
        {
            var query = "INSERT INTO Users (UserName, Password, Email) VALUES (@UserName, @Password, @Email);";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static List<GreenHouse> GetGreenHouses()
        {
            string query = $"SELECT * FROM GreenHouses;";
            List<GreenHouse> greenHouses = new List<GreenHouse>();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var command = new SqlCommand(query, connection))
                    {

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                GreenHouse garden = new GreenHouse()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    Type = (TypeOfGreenHouse)reader.GetByte(reader.GetOrdinal("Type")),
                                    Size = (double)reader.GetDecimal(reader.GetOrdinal("Area")),
                                    NumberOfPlants = reader.GetInt32(reader.GetOrdinal("NumberOfPlants"))
                                };
                                greenHouses.Add(garden);
                            }
                            connection.Close();
                        }
                    }
                }
                return greenHouses;
            }
            catch
            {
                return null;
            }
        }

        public static bool AddGarden(GreenHouse garden)
        {
            var query = "UPDATE Greenhouses SET Type = @Type, Area = @Area, NumberOfPlants = @NumberOfPlants WHERE Id = @Id " +
                "IF @@ROWCOUNT = 0 " +
                "INSERT INTO Greenhouses (Type, Area, NumberOfPlants) VALUES (@Type, @Area, @NumberOfPlants);";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", garden.Id);
                        command.Parameters.AddWithValue("@Type", garden.Type);
                        command.Parameters.AddWithValue("@Area", garden.Size);
                        command.Parameters.AddWithValue("@NumberOfPlants", garden.NumberOfPlants);
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteGarden(int gardenId)
        {
            var query = "DELETE FROM GreenHouses WHERE Id = @Id;";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", gardenId);
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
