using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xaml;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Resources;
using MySql.Data.MySqlClient;
using System.Data;

namespace BengkelAtmaAuto
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class menu_Akun : Window
    {
        public menu_Akun()
        {
            InitializeComponent();
        }
        AkunDAO ao = new AkunDAO();
        //DataGrid dg = new DataTable;
        void showData()
        {
            DataSet data = ao.getData();
          
           //DataGrid.DataSource = data;
           //DataGrid.DataMember = "users";
           
            
        }




    }
}
