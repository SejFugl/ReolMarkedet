using ReolMarkedetNet.DataModels;
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

namespace ReolMarkedetNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ShelfRepository shelfRepository = new ShelfRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int inputShelfId = 2;

            Shelf shelf = shelfRepository.GetShelf(inputShelfId);

            if (shelf != null)
            {
                MessageBox.Show($"Shelf ID: {shelf?.shelfId}" +
                    $"\nLocation: {shelf?.location}" +
                    $"\nCategory: {shelf?.Category}" +
                    $"\nOwner ID: {shelf?.ownerId}");
            }
            else
            {
                MessageBox.Show("Shelf not found");
            }
        }

        private void CreateShelf_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string location = txtLocation.Text;
                string category = txtCategory.Text;
                int? ownerId = null;

                if (!string.IsNullOrEmpty(txtOwnerId.Text))
                {
                    ownerId = int.Parse(txtOwnerId.Text);
                }

                Shelf newShelf = new Shelf
                {
                    location = location,
                    Category = category,
                    ownerId = ownerId
                };

                ShelfRepository shelfRepository = new ShelfRepository();
                shelfRepository.CreateShelf(newShelf);

                MessageBox.Show("Ny reol oprettet");

                txtLocation.Clear();
                txtCategory.Clear();
                txtOwnerId.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i oprettelsen af ny reol: {ex.Message}");
            }
        }

        private void UpdateShelf_Click(object sender, RoutedEventArgs e )
        {
            try
            {
                int shelfId = int.Parse(txtShelfId.Text);
                
                ShelfRepository shelfRepository = new ShelfRepository();

                Shelf existingShelf = shelfRepository.GetShelf(shelfId);

                if (existingShelf != null)
                {
                    existingShelf.location = txtLocation.Text;
                    existingShelf.Category = txtCategory.Text;
                    existingShelf.ownerId = int.Parse(txtOwnerId.Text);

                    shelfRepository.UpdateShelf(existingShelf);

                    MessageBox.Show("Reol opdateret");
                }
                else
                {
                    MessageBox.Show("Reol findes ikke");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i opdatering af reol: {ex.Message}");
            }
        }

        private void DeleteShelf_Click(object sender, RoutedEventArgs e )
        {
            try
            {
                int shelfId = int.Parse(txtShelfId.Text);

                ShelfRepository shelfRepository = new ShelfRepository();

                Shelf shelfToDelete = shelfRepository.GetShelf(shelfId);

                if (shelfToDelete != null)
                {
                    shelfRepository.DeleteShelf(shelfId);

                    MessageBox.Show("Reol slettet");
                }
                else
                {
                    MessageBox.Show("Reol findes ikke");
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show($"Fejl i sletning af reol: {ex.Message}");
            }
        }
    }
}
