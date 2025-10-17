using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum9
{
    public partial class Hallogin : Form
    {
        List<User> users; 
        public Hallogin(List<User> userss)
        {
            InitializeComponent();
            users = userss;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbusernamelog.Text;
            string password = tbpasswordlog.Text;
            bool status = false; // kalau tidak ada


            foreach (User user in users)
            {
                if ((user.Username == username) && (user.Password == password))
                {
                    status = true;
                    break;
                }

            }
            if (status)
            {
                MessageBox.Show("selamat anda berhasil login bruh dan selesaiii");
            }
        }
    }
}
