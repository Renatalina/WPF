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

namespace WPFStulish
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            //это для оконных приложений 
            Button4.Style = this.Resources["ButtonStyle"] as Style;
            Button4.Style = this.FindResource("ButtonStyle") as Style;
            */


            //это для WrapPanel
            Button4.Style = wrapPanel.Resources["ButtonStyle"] as Style;
            Button4.Style = wrapPanel.FindResource("ButtonStyle") as Style;


        }
    }
}
