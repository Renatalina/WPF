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

namespace WPFPages
{
    /// <summary>
    /// Interaction logic for FancyWindow.xaml
    /// </summary>
    public partial class FancyWindow : Window
    {
        public FancyWindow()
        {
            InitializeComponent();
        }
        private void window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void cmdClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
