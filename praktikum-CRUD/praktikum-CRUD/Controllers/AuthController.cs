using Npgsql;
using praktikum_CRUD.Database;
using praktikum_CRUD.Models;
using praktikum_CRUD.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_CRUD.Controller
{
    public class AuthController
    {
        private DbContext _dbContext;

        public AuthController()
        {
            _dbContext = new DbContext();
        }

        public bool Login(User user)
        {
            using (var conn = new NpgsqlConnection(_dbContext.connStr) )
            {
                conn.Open();
                string query = "SELECT 1 FROM users WHERE username = @username AND password = @password LIMIT 1";
                
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);

                    using (var read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            return true;
                        }

                        return false;
                    }
                }
            }
        }

        public bool Register(User user)
        {
            using (var conn = new NpgsqlConnection(_dbContext.connStr))
            {
                conn.Open();
                string query = "INSERT INTO users(username, password) VALUES(@username, @password)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }

        public void showLoginForm(Form form)
        {
            form.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        public void showRegisterForm(Form form)
        {
            form.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
