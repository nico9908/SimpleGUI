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

namespace SimpleGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string temp;

            temp = First.Text;
            First.Text = Second.Text;
            Second.Text = Third.Text;
            Third.Text = Fourth.Text;
            Fourth.Text = temp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            First.Clear();
            Second.Clear();
            Third.Clear();
            Fourth.Clear();
            MessageBox.Show("The data has been cleared!", "Warning!", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string temp;

            temp = Fourth.Text;
            Fourth.Text = Third.Text;
            Third.Text = Second.Text;
            Second.Text = First.Text;
            First.Text = temp;
        }
    }
}
