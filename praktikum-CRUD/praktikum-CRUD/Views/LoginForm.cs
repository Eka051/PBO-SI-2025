
using praktikum_CRUD.Controller;
using praktikum_CRUD.Models;

namespace praktikum_CRUD
{
    public partial class LoginForm : Form
    {
        private AuthController _authController;
        public LoginForm()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _authController.showRegisterForm(this);
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

            var auth = _authController.Login(user);
            if (auth)
            {
                MessageBox.Show($"Login berhasil. Selamat datang {user.Username}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Username atau Password salah. Silahkan periksa kredensial akun anda!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
