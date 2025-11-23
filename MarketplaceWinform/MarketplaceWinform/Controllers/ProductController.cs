using MarketplaceWinform.Database;
using MarketplaceWinform.Helpers;
using MarketplaceWinform.Interfaces;
using MarketplaceWinform.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceWinform.Controllers
{
    public class ProductController : IProduct
    {
        private DbContext _dbContext;

        public ProductController()
        {
            _dbContext = new DbContext();
        }

        public void CreateProduct(Product product)
        {
            try
            {
                if (AppSession.CurrentUser == null)
                {
                    MessageBox.Show("User tidak terautentikasi. Silakan login terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (AppSession.CurrentUser.UserId <= 0)
                {
                    MessageBox.Show($"UserId tidak valid: {AppSession.CurrentUser.UserId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO products(image, product_name, price, stock, user_id, created_at)
                    VALUES (@image, @productName, @price, @stock, @userId, NOW())";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@image", product.Image);
                        cmd.Parameters.AddWithValue("@productName", product.ProductName);
                        cmd.Parameters.AddWithValue("@price", product.Price);
                        cmd.Parameters.AddWithValue("@stock", product.Stock);
                        cmd.Parameters.AddWithValue("@userId", AppSession.CurrentUser.UserId);

                        cmd.ExecuteNonQuery();
                        
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Create Product Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Product> GetByUserId(int userId)
        {
            List<Product> products = new List<Product>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"SELECT id, product_name, stock, price, user_id
                    FROM products WHERE user_id = @userId";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                       
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product 
                                { 
                                    ProductId = reader.GetInt32(0),
                                    ProductName = reader.GetString(1),
                                    Stock = reader.GetInt32(2),
                                    Price = reader.GetInt32(3),
                                    UserId = reader.GetInt32(4),
                                };
                                products.Add(product);
                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Get Product By UserID Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }

        public List<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"SELECT id, product_name, stock, price, user_id, image
                    FROM products";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Product product = new Product
                                {
                                    ProductId = reader.GetInt32(0),
                                    ProductName = reader.GetString(1),
                                    Stock = reader.GetInt32(2),
                                    Price = reader.GetInt32(3),
                                    UserId= reader.GetInt32(4),
                                    Image = reader["image"] as byte[]
                                };
                                products.Add(product);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Get Product By UserID Error: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return products;
        }
    }
}
