using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BengkelAtmaAuto
{
    /// <summary>
    /// Interaction logic for menu_Akun.xaml
    /// </summary>
    public partial class menu_Akun : Window
    {
        public menu_Akun()
        {
            InitializeComponent();
        }
        public void FillGrid()
        {
            string MyConString =
            "SERVER=localhost;" +
            "DATABASE=8991;" +
            "UID=root;" +
            "PASSWORD=admin;";

            string sql = "SELECT id_user, username, password FROM users ORDER BY id_user";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    dtAkun.DataContext = dt;
                }
                connection.Close();
            }
        }

        private void DtAkun_Loaded(object sender, RoutedEventArgs e)
        {
            FillGrid();
        }
    }
}
