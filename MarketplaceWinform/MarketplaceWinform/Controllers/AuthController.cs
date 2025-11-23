using MarketplaceWinform.Database;
using MarketplaceWinform.Helpers;
using MarketplaceWinform.Models;
using Npgsql;

namespace MarketplaceWinform.Controllers
{
    public class AuthController
    {
        private DbContext _dbContext;

        public AuthController()
        {
            _dbContext = new DbContext();
        }

        public UserModel Login(UserModel user)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT user_id, role, full_name, username, password FROM users 
                        WHERE username = @username AND password = @password LIMIT 1";


                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        string hashedPassword = PasswordHelper.HashPassword(user.Password);

                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using(var read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                int userId = read.GetInt32(0);
                                string role = read.GetString(1);
                                UserRole roleEnum = (UserRole)Enum.Parse(typeof(UserRole), role);

                                UserModel loggedInuser = new UserModel
                                {
                                    UserId = userId,
                                    Role = roleEnum,
                                    FullName = read.GetString(2),
                                    Username = read.GetString(3),
                                    Password = hashedPassword,
                                };

                                return loggedInuser;
                            }

                            return null;

                        }
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show($"LOGIN ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Register(UserModel user)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                    INSERT INTO users(full_name, username, password, role)
                    VALUES(@fullname, @username, @password, @role)";

                    string hashPassword = PasswordHelper.HashPassword(user.Password);

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fullname", user.FullName);
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", hashPassword);
                        cmd.Parameters.AddWithValue("@role", user.Role.ToString());

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Register ERROR: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
