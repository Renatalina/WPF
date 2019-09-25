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

namespace WPFResource
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
            Img1.Source = new BitmapImage(new Uri("pack://application:,,,/Images/fon.png"));
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            ///1
            //SolidColorBrush brush = this.Resources["ButtonBrush"] as SolidColorBrush;
            ////здесь нужно привести к нужному типу
            ////здесь мы изменяем, а не заменяем
            //if(brush!=null)
            //{
            //    brush.Opacity = 0.5;
            //}
            ///2
            ///Resources["ButtonBrush"]= new SolidColorBrush(Colors.Aquamarine);


            //SolidColorBrush brush=Wnd.FindResource("ButtonBrush") as SolidColorBrush;
            // if(brush!=null)
            // {
            //     brush = new SolidColorBrush(Colors.Aquamarine);
            // }
            SolidColorBrush brush = Wnd.FindResource("ButtonBrush") as
                SolidColorBrush;
            if(brush!=null)
            {
                brush.Opacity = 0.5;
            }


        }
    }
}
