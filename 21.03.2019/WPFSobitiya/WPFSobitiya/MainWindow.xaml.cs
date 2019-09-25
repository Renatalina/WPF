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

namespace WPFSobitiya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly DependencyProperty SpaceProperty;

        public int Space
        {
            get { return (int)GetValue(SpaceProperty); }
            set { SetValue(SpaceProperty, value); }
        }

        static MainWindow()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata
            {
                Inherits = true
            };
            SpaceProperty = SpaceButton.SpaceProperty.AddOwner(typeof(MainWindow));
            SpaceProperty.OverrideMetadata(typeof(MainWindow), metadata);
        }
        //// Using a DependencyProperty as the backing store for Space.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty SpaceProperty =
        //    DependencyProperty.Register("Space", typeof(int), typeof(ownerclass), new PropertyMetadata(0));


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Font_Click(object sender, RoutedEventArgs e)
        {
            Button button = (sender as Button);
            string str=button.Name.Substring(button.Name.LastIndexOf('_') + 1);
            //в str запишем остаток от имени Фонт_8 (8) и так мы сможем пройтись по всем именам 
            
            if (button!=null)
            {
                double size = 0;
                if( double.TryParse(button.Name.Substring(button.Name.LastIndexOf('_') + 1), out size))
                    {
                    FontSize = size;
                }
                //трай пас возвращает тру, и в переменую size записывается значение
                try
                {

                    //this.FontSize = double.Parse(button.Name.Substring(button.Name.LastIndexOf('_') + 1));
                    //еще один вариант
                    //switch(button.Name)
                    //{
                    //    case "Font_8":
                    //        break;
                    //    default:
                    //        break;
                    //}
                }
                catch (Exception)
                {

                    throw;
                }
            }


        }

        private void Window_Click(object sender, RoutedEventArgs e)
        {
            Button button = (e.Source as Button);            

            if (button != null)
            {
                double size = 0;
                if (double.TryParse(button.Name.Substring
                    (button.Name.LastIndexOf('_') + 1),
                    out size))
                {
                   button.FontSize = size;
                }
            }
           // (sender as Button).FontSize = 12;

        }

        private void SpaceButton_Click(object sender, RoutedEventArgs e)
        {
            SpaceButton spaceButton = (sender as SpaceButton);
            if(spaceButton !=null)
            {
                spaceButton.Space = 3;
            }
        }

        private void SpaceWindow_Click(object sender, RoutedEventArgs e)
        {
            SpaceButton spaceButton = (sender as SpaceButton);
            if (spaceButton != null)
            {
                this.Space = Convert.ToInt32(spaceButton.Tag);
            }
        }
    }
}
