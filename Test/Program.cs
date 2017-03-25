using System;
using System.Data.SqlClient;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var connection = new SqlConnection("Server=tcp:192.168.1.4,1433;Initial Catalog=master;user id=test;password=test;"))
            {
                var command = new SqlCommand("SELECT @@SERVERNAME", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]}");
                    }
                }
            }

            using (var connection = new SqlConnection("Server=tcp:192.168.1.4,1433;Initial Catalog=master;user id=test;password=test;"))
            {
                var command = new SqlCommand("SELECT @@SERVERNAME", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]}");
                    }
                }
            }

            using (var connection = new SqlConnection("Server=tcp:192.168.1.4,1433;Initial Catalog=master;user id=test;password=test;"))
            {
                var command = new SqlCommand("SELECT @@SERVERNAME", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]}");
                    }
                }
            }
        }
    }
}