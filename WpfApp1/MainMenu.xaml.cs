using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BengkelAtmaAuto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class mainMenu : Window
    {
        public mainMenu()
        {
            InitializeComponent();
        }


        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
           
            if (tbUsername.Text.Equals("panda") && tbPassword.Equals("panda123"))
            {
                menu dashboard = new menu();  //code buat pindah menu.,
                dashboard.Show();
                this.Hide();
            }
            else
            {

            }

        }

    }
}
