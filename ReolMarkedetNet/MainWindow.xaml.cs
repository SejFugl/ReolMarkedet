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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2;

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

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            // Start fade-out animation
            var fadeOutStoryboard = (Storyboard)this.Resources["FadeOutStoryboard"];
            fadeOutStoryboard.Completed += (s, args) =>
            {
                Page1 page1 = new Page1();
                page1.Width = this.ActualWidth;
                page1.Height = this.ActualHeight;

                // Naviger til Page1
                Frame1.Navigate(page1);

                // Start fade-in animation
                var fadeInStoryboard = (Storyboard)this.Resources["FadeInStoryboard"];
                fadeInStoryboard.Begin(MainGrid);
            };
            fadeOutStoryboard.Begin(MainGrid);
        }
    }
}
