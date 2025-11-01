using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum9.Models
{
    public class LoginContext
    {
        private readonly NpgsqlConnection conn;

        public LoginContext()
        {
            string env = Environment.GetEnvironmentVariable("CONNECTION_STRING")!;
            conn = new NpgsqlConnection(env);
            conn.Open(); // Untuk membuka koneksi ke PostgreSQL
        }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM users WHERE username = @username AND password = @password";
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                if (cmd.Parameters.Count > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
