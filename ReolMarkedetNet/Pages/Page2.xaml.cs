using ReolMarkedetNet;
using ReolMarkedetNet.DataModels;
using ReolMarkedetNet.Input_Windows;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private int ownerId;

        public Page2(int ownerId)
        {
            InitializeComponent();
            this.ownerId = ownerId;
        }

        private void GetShelfProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new InputShelfProduct();
                if (dialog.ShowDialog() == true)
                {
                    int productId = int.Parse(dialog.txtProductId.Text);

                    ShelfProductRepository shelfProductRepository = new ShelfProductRepository();
                    ShelfProduct shelfProduct = shelfProductRepository.GetShelfProduct(productId);

                    if (shelfProduct != null && shelfProduct.ownerId == ownerId)
                    {
                        MessageBox.Show($"Product ID: {shelfProduct?.productId}" +
                            $"\nBarcode: {shelfProduct?.barcode}" +
                            $"\nProduct Description: {shelfProduct?.productDescription}" +
                            $"\nPrice: {shelfProduct?.price}" +
                            $"\nShelf ID: {shelfProduct?.shelfId}" +
                            $"\nOwner ID: {shelfProduct?.ownerId}");
                    }
                    
                    else
                    {
                        MessageBox.Show("Product not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i visning af reolvare: {ex.Message}");
            }
        }

        private void CreateShelfProduct_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteShelfProduct_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateShelfProduct_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GetSale_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NavigateBackToMain(object sender, RoutedEventArgs e)
        {
            // Opret en instans af MainWindow
            MainWindow mainWindow = new MainWindow();

            // Kopier placering og størrelse fra det nuværende vindue (Page1)
            mainWindow.Left = Window.GetWindow(this).Left;
            mainWindow.Top = Window.GetWindow(this).Top;
            mainWindow.Width = Window.GetWindow(this).Width;
            mainWindow.Height = Window.GetWindow(this).Height;

            // Gem vinduets tilstand (minimeret eller maksimeret)
            if (Window.GetWindow(this).WindowState == WindowState.Maximized)
            {
                mainWindow.WindowState = WindowState.Maximized;
            }

            // Vis MainWindow med gemte indstillinger
            mainWindow.Show();

            // Luk den nuværende side (Page1)
            Window.GetWindow(this).Close();
        }
    }
}
