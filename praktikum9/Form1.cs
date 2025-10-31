using Npgsql;

namespace praktikum9
{
    public partial class Form1 : Form
    {
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

            //users.Add(new User { Username = username, Password = password });
            //try
            //{
            //    Database db = new Database();
            //    var regis = db.Register(username, password);

            //    if (regis == 1)
            //    {
            //        MessageBox.Show("Selamat anda berhasil membuat akun");
            //        TBUsername.Clear();
            //        TBPassword.Clear();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Gagal membuat akun");
            //    }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show($"{err}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

//public class Database
//{
//    NpgsqlConnection conn;

//    public Database()
//    {
//        string env = Environment.GetEnvironmentVariable("CONNECTION_STRING")!;
//        conn = new NpgsqlConnection(env);
//        conn.Open();
//    }

//    public int Register(string username, string password)
//    {
//        string query = "INSERT INTO users(username, password) VALUES (@username, @password)";
//        NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
//        cmd.Parameters.AddWithValue("@username", username);
//        cmd.Parameters.AddWithValue("@password", password);
//        var register = cmd.ExecuteNonQuery(); // fungsinya untuk mengeksekusi query yang tidak mereturn value (INSERT, UPDATE, CREATE)

//        return register;
//    }
//}
