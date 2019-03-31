using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Data.SqlClient;

namespace BengkelAtmaAuto
{
    class AkunDAO
    {
        private MySqlCommand task = null;
        string config= "Server=localhost;Port=3306;UID=root;PWD=admin;Database=8991";
        MySqlConnection conn = new MySqlConnection();

        public AkunDAO()
        {
            conn.ConnectionString = config;
        }

        public DataSet getData()
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                task.Connection = conn;
                task.CommandType = CommandType.Text;
                task.CommandText = "Select id_user,username,password FROM users";
                MySqlDataAdapter mdap = MySqlDataAdapter(task);
                mdap.Fill(ds, "users");
                conn.Close();
                
            }
            catch (MySqlException)
            {

            }
            return ds;
        }

        private MySqlDataAdapter MySqlDataAdapter(MySqlCommand task)
        {
            throw new NotImplementedException();
        }
    }
}
