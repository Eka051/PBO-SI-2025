using MarketplaceWinform.Controllers;
using MarketplaceWinform.Helpers;
using MarketplaceWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketplaceWinform.Views
{
    public partial class RegisterView : Form
    {
        private AuthController controller;
        public RegisterView()
        {
            InitializeComponent();
            controller = new AuthController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname = tbFullname.Text;
                string username = tbUsername.Text;
                string password = PasswordHelper.HashPassword(tbPassword.Text);

                if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Semua field harus diisi!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    UserModel userRegister = new UserModel 
                    { 
                        FullName = fullname,
                        Username = username,
                        Password = password,
                        Role = UserRole.admin
                    };
                    var success = controller.Register(userRegister);
                    if (success)
                    {
                        MessageBox.Show("Registrasi berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginView loginView = new LoginView();
                        loginView.FormClosed += (s, args) => this.Close();
                        this.Hide();
                        loginView.Show();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Gagal melakukan pendaftaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
