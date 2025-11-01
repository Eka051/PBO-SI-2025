using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum9.Models
{
    public class User
    {
        private int Id;
        private string Username;
        private string Password;

        public int id
        {
            get {  return Id; }
            set { Id = value; }
        }

        public string username
        {
            get { return Username; }
            set { username = value; }
        }

        public string password
        {
            get { return Password; }
            set { password = value; }
        }
    }
}
