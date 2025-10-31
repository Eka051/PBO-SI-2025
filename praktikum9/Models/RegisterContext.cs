using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum9.Models
{
    public class RegisterContext
    {
        private readonly NpgsqlConnection conn;

        public RegisterContext()
        {
            string env = Environment.GetEnvironmentVariable("CONNECTION_STRING")!;
            conn = new NpgsqlConnection(env);
            conn.Open(); // Untuk membuka koneksi ke PostgreSQL
        }

        public bool Register(User users)
        {

            string query = "INSERT INTO users (username,password) VALUES (@username,@password)";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", users.username);
                cmd.Parameters.AddWithValue("@password", users.password);

               int var = cmd.ExecuteNonQuery();

                if (var > 0)
                {
                    return true;
                }
                return false;
                
            }
        }
    }
}
