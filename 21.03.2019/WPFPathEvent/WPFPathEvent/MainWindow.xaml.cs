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

namespace WPFPathEvent
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

        private void StackPanel_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "StackPanel_MouseRightButtonUp\n";

        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbInfo.Clear();
        }
        private void StackPanel_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "StackPanel_PreviewMouseRightButtonUp\n";
            //e.Handled = true;
            //Хандел это прекращение события

        }

        private void btnMain_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "btnMain_PreviewMouseRightButtonUp\n";
        }

        private void btnMain_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "btnMain_MouseRightButtonUp\n";
        }

      
        private void btnTwo_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "btnTwo_MouseRightButtonUp\n";
        }

        private void btnTwo_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            tbInfo.Text += "btnTwo_PreviewMouseRightButtonUp\n";
        }
        private void Source_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label label = sender as Label;
            if(label!=null)
            {
                DragDrop.DoDragDrop(label, label.Content, DragDropEffects.Copy);
            }
        }
        private void Label_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void Target_Drop(object sender, DragEventArgs e)
        {
            Label label = sender as Label;
            if (label !=null)
            {
                label.Content = e.Data.GetData(DataFormats.Text).ToString();
            }
        }

     
    }
}
