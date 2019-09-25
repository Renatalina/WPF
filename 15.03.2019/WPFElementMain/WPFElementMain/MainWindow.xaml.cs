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

namespace WPFElementMain
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Label label = new Label
            {
                Name = "Label1",
                Content = "Text2",
                Margin = new Thickness(5)
            };
            Button button = new Button
            {
                Content = "Click",
                Width = 100,
                Height = 10
               
                
            };
            button.Click += Button_Click;            
            grid.Children.Add(button);
            Grid.SetColumn(button, 1);
            Grid.SetRow(button, 1);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ho-ho-ho");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Pass.Password);
            Progress.IsIndeterminate = false;
        }
    }
}
