namespace praktikum9
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = TBUsername.Text;
            string password = TBPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)) 
            {
                MessageBox.Show("Username atau password harus diisi!", "Tidak Valid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
                return;
            }

            users.Add(new User { Username = username, Password = password });
            MessageBox.Show("Selamat anda berhasil membuat akun");
            TBUsername.Clear();
            TBPassword.Clear();

        
            Hallogin hallogin = new Hallogin(users);
            this.Hide();
            hallogin.Show();
            


            //foreach ( User user in users )
            //{
            //    label4.Text = user.Username;
            //}

        }
    }
}

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}
