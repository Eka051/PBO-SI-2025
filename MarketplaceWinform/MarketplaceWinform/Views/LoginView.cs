using MarketplaceWinform.Controllers;
using MarketplaceWinform.Helpers;
using MarketplaceWinform.Interfaces;
using MarketplaceWinform.Models;
using MarketplaceWinform.Views.Admin;
using MarketplaceWinform.Views.User;

namespace MarketplaceWinform.Views
{
    public partial class LoginView : Form
    {
        private AuthController authController;
        private readonly IProduct productInterface;
        public LoginView()
        {
            InitializeComponent();
            authController = new AuthController();
            productInterface = new ProductController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username & Password harus diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string hashPassword = PasswordHelper.HashPassword(password);
                UserModel user = new UserModel
                {
                    Username = username,
                    Password = hashPassword
                };

                var auth = authController.Login(user);
                if (auth != null)
                {
                    MessageBox.Show($"Login Berhasil. Selamat datang {user.Username}", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AppSession.SetUser(auth);

                    if (AppSession.CurrentUser.Role == UserRole.admin)
                    {
                        AdminDashboardView admin = new AdminDashboardView(productInterface);
                        admin.FormClosed += (s, args) => this.Close();
                        admin.Show();
                        this.Hide();
                    } else
                    {
                        UserDashboardView userView = new UserDashboardView();
                        userView.FormClosed += (s, args) => this.Close();
                        userView.Show();
                        this.Hide();
                    }

                } else
                {
                    MessageBox.Show("Username atau Password salah. Silahkan Coba Lagi!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"Gagal Login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
