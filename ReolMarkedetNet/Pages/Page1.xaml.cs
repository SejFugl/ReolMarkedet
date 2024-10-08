﻿using ReolMarkedetNet;
using ReolMarkedetNet.DataModels;
using ReolMarkedetNet.Input_Windows;
using ReolMarkedetNet.Windows;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void NavigateBackToMain(object sender, RoutedEventArgs e)
        {
            // Opret en instans af MainWindow og vis den
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            // Luk den nuværende side (Page1)
            Window.GetWindow(this).Close();
        }

        private void GetOwner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new InputOwner();
                if (dialog.ShowDialog() == true)
                {
                    int ownerId = int.Parse(dialog.txtOwnerId.Text);

                    ShelfOwnerRepository shelfOwnerRepository = new ShelfOwnerRepository();
                    ShelfOwner shelfOwner = shelfOwnerRepository.GetShelfOwner(ownerId);

                    if (shelfOwner != null)
                    {
                        MessageBox.Show($"Owner ID: {shelfOwner?.ownerId}" +
                            $"\nFirst Name: {shelfOwner?.firstName}" +
                            $"\nLast Name: {shelfOwner?.lastName}" +
                            $"\nPhone Number: {shelfOwner?.phoneNumber}" +
                            $"\nEmail: {shelfOwner?.email}");
                    }
                    else
                    {
                        MessageBox.Show("Owner not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i visning af ejer: {ex.Message}");
            }
        }

        private void CreateOwner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new InputOwner();
                if (dialog.ShowDialog() == true)
                {
                    string firstName = dialog.txtFirstName.Text;
                    string lastName = dialog.txtLastName.Text;
                    string phoneNumber = dialog.txtPhoneNumber.Text;
                    string email = dialog.txtEmail.Text;

                    ShelfOwner newShelfOwner = new ShelfOwner
                    {
                        firstName = firstName,
                        lastName = lastName,
                        phoneNumber = phoneNumber,
                        email = email
                    };

                    ShelfOwnerRepository shelfOwnerRepository = new ShelfOwnerRepository();
                    shelfOwnerRepository.CreateShelfOwner(newShelfOwner);

                    MessageBox.Show("Ny ejer oprettet");

                    dialog.txtOwnerId.Clear();
                    dialog.txtFirstName.Clear();
                    dialog.txtLastName.Clear();
                    dialog.txtPhoneNumber.Clear();
                    dialog.txtEmail.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i oprettelsen af ny ejer: {ex.Message}");
            }
        }

        private void DeleteOwner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new InputOwner();
                if (dialog.ShowDialog() == true)
                {
                    int ownerId = int.Parse(dialog.txtOwnerId.Text);

                    ShelfOwnerRepository shelfOwnerRepository = new ShelfOwnerRepository();

                    ShelfOwner ownerToDelete = shelfOwnerRepository.GetShelfOwner(ownerId);

                    if (ownerToDelete != null)
                    {
                        shelfOwnerRepository.DeleteShelfOwner(ownerId);

                        MessageBox.Show("Ejer slettet");
                    }
                    else
                    {
                        MessageBox.Show("Ejer findes ikke");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i sletning af ejer: {ex.Message}");
            }
        }

        private void UpdateOwner_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new InputOwner();
                if (dialog.ShowDialog() == true)
                {
                    int ownerId = int.Parse(dialog.txtOwnerId.Text);
                    string firstName = dialog.txtFirstName.Text;
                    string lastName = dialog.txtLastName.Text;
                    string phoneNumber = dialog.txtPhoneNumber.Text;
                    string email = dialog.txtEmail.Text;

                    ShelfOwnerRepository shelfOwnerRepository = new ShelfOwnerRepository();

                    ShelfOwner existingOwner = shelfOwnerRepository.GetShelfOwner(ownerId);

                    if (existingOwner != null)
                    {
                        existingOwner.firstName = dialog.txtFirstName.Text;
                        existingOwner.lastName = dialog.txtLastName.Text;
                        existingOwner.phoneNumber = dialog.txtPhoneNumber.Text;
                        existingOwner.email = dialog.txtEmail.Text;

                        shelfOwnerRepository.UpdateShelfOwner(existingOwner);

                        MessageBox.Show("Ejer opdateret");
                    }
                    else
                    {
                        MessageBox.Show("Ejer findes ikke");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i opdatering af ejer: {ex.Message}");
            }
        }

        private void CreateShelf_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new Input();
                if (dialog.ShowDialog() == true)
                {
                    string location = dialog.txtLocation.Text;
                    string category = dialog.txtCategory.Text;
                    int? ownerId = null;

                    if (!string.IsNullOrEmpty(dialog.txtOwnerId.Text))
                    {
                        ownerId = int.Parse(dialog.txtOwnerId.Text);
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

                    dialog.txtLocation.Clear();
                    dialog.txtCategory.Clear();
                    dialog.txtOwnerId.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i oprettelsen af ny reol: {ex.Message}");
            }
        }

        private void GetShelf_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new Input();
                if (dialog.ShowDialog() == true)
                {
                    int shelfId = int.Parse(dialog.txtShelfId.Text);

                    ShelfRepository shelfRepository = new ShelfRepository();
                    Shelf shelf = shelfRepository.GetShelf(shelfId);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i visning af reol: {ex.Message}");
            }
        }

        private void UpdateShelf_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new Input();
                if (dialog.ShowDialog() == true)
                {
                    int shelfId = int.Parse(dialog.txtShelfId.Text);
                    string location = dialog.txtLocation.Text;
                    string category = dialog.txtCategory.Text;
                    int ownerId = int.Parse(dialog.txtOwnerId.Text);

                    ShelfRepository shelfRepository = new ShelfRepository();

                    Shelf existingShelf = shelfRepository.GetShelf(shelfId);

                    if (existingShelf != null)
                    {
                        existingShelf.location = dialog.txtLocation.Text;
                        existingShelf.Category = dialog.txtCategory.Text;
                        existingShelf.ownerId = int.Parse(dialog.txtOwnerId.Text);

                        shelfRepository.UpdateShelf(existingShelf);

                        MessageBox.Show("Reol opdateret");
                    }
                    else
                    {
                        MessageBox.Show("Reol findes ikke");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i opdatering af reol: {ex.Message}");
            }
        }

        private void DeleteShelf_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dialog = new Input();
                if (dialog.ShowDialog() == true)
                {
                    int shelfId = int.Parse(dialog.txtShelfId.Text);

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fejl i sletning af reol: {ex.Message}");
            }
        }
    }
}