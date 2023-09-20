using Microsoft.Data.SqlClient;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReolMarkedet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            string connectionString = "Data Source=10.56.8.36;Initial Catalog=DB_F23_TEAM_11;Persist Security Info=True;User ID=DB_F23_TEAM_11;Password=TEAMDB_DB_11;Trust Server Certificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
