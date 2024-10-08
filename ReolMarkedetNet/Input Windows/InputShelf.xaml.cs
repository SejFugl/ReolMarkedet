﻿using System;
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

namespace ReolMarkedetNet.Windows
{
    /// <summary>
    /// Interaction logic for Input.xaml
    /// </summary>
    public partial class Input : Window
    {
        public int shelfId {get; set;}
        public string location { get; set; }
        public string Category { get; set; }
        public int ownerId { get; set; }

        public Input()
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
