﻿using System.Windows.Controls;
using System.Windows;
using System;

namespace ReolMarkedet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            {
                InitializeComponent();

                // Indstil vinduets bredde og højde til det ønskede størrelse
                this.Width = 800; // Skift 800 til den ønskede bredde
                this.Height = 600; // Skift 600 til den ønskede højde

                // Indstil vinduets placering til CenterScreen (midten af skærmen)
                this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Page1 page1 = new Page1();
            page1.Width = this.ActualWidth;
            page1.Height = this.ActualHeight;

            // Naviger til Page1
            this.Content = page1;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
           
        }

    }
}