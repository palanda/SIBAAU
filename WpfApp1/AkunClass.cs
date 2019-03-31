using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengkelAtmaAuto
{
    class AkunClass
    {

        private int id_user;
        private string username, password;

        public int Id_user { get => id_user; set => id_user = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }


}
