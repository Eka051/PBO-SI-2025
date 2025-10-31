using praktikum9.Models;

namespace praktikum9
{
    public partial class Hallogin : Form
    {
        private readonly LoginContext _loginContext;
        public Hallogin(LoginContext loginContext)
        {
            InitializeComponent();
            _loginContext = loginContext;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbusernamelog.Text;
            string password = tbpasswordlog.Text;

            try
            {
               var auth = _loginContext.Login(username, password);
                if (auth)
                {
                    MessageBox.Show("Anda Berhasil Login", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Gagal Login {ex}", "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
