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
using System.Windows.Shapes;

namespace ReolMarkedetNet.Input_Windows
{
    /// <summary>
    /// Interaction logic for InputShelfProduct.xaml
    /// </summary>
    public partial class InputShelfProduct : Window
    {
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public int ShelfId { get; set; }
        public int OwnerId { get; set; }

        public InputShelfProduct()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
