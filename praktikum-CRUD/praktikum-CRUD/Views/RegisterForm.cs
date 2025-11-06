using praktikum_CRUD.Controller;
using praktikum_CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_CRUD.View
{
    public partial class RegisterForm : Form
    {
        private AuthController _authController;
        public RegisterForm()
        {
            InitializeComponent();
            _authController = new AuthController();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showLoginForm(this);
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
            btnShowPassword.BackgroundImage = tbPassword.UseSystemPasswordChar ? Properties.Resources.eyeOff : Properties.Resources.eyeOn;
            btnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password))
            {
                MessageBox.Show("Username dan Password harus di isi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var valid = _authController.Register(user);

            if (valid)
            {
                MessageBox.Show("Registrasi berhasil. Silahkan Login", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _authController.showLoginForm(this);
            } else
            {
                MessageBox.Show("Registrasi Gagal. Silahkan coba lagi!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
