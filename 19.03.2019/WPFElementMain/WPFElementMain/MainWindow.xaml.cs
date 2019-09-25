using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            /*progress.IsIndeterminate = false;

            if (listBox.SelectedIndex >= 0)
            {
                string str = string.Empty;
                foreach (var item in listBox.SelectedItems)
                {
                    str += $"{(item as ListBoxItem).Content.ToString()}{Environment.NewLine}";
                }
                MessageBox.Show(str);
            }*/
            if (ListB.SelectedIndex>=0)
            {
                // ListBoxItem item = ListB.SelectedItem as ListBoxItem;  // так он выберет нужный нам айтем и выведет его на экран
                //MessageBox.Show(item.Content.ToString());//так мы выведем на экран строку из лист бокс
                
                //или вот так можно выводить на экран
                foreach (var item in ListB.SelectedItems)
                {
                    MessageBox.Show((item as ListBoxItem).Content.ToString());
                }
            }
        }

        private void ListB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Если мы будем руками создавать лист бокс
            /*    ListBox MyControl = new ListBox();
            MyControl.Name = "ListBox1";
            MyControl.Margin = new Thickness(30);
            MyControl.Items.Add("BMW");
            MyControl.Items.Add("Ferrari");
            MyControl.Items.Add("Ford");
            MyControl.Items.Add("Honda");
            grid.Children.Add(MyControl);*/
            if (ListB.SelectedItem!=null)
            {
                string str = string.Empty;
                foreach(var item in ListB.SelectedItems)
                {
                   // str += (item as ListBoxItem).Content.ToString();
                  //  MessageBox.Show(str);
                    ////
                    //или вот так можно
                    MessageBox.Show((ListB.SelectedItem as ListBoxItem).Content.ToString());

                }
            }
            //Таб контрол создали руками
            /*TabControl Tab = new TabControl();
            Tab.Items.Add(new TabItem() { Header = "One" });
            TabItem Item = new TabItem();
            Item.Header = "Two";
            StackPanel Stack = new StackPanel() { Margin = new Thickness(6)};
            TextBox MyTextBox = new TextBox() { Margin = new Thickness(6) };
            Button MyButton = new Button() { Margin = new Thickness(6) };
            MyButton.Content = "Ok";
            Stack.Children.Add(MyTextBox);
            Stack.Children.Add(MyButton);
            Item.Content = Stack;
            Tab.Items.Add(Item);
            Tab.Items.Add(new TabItem() { Header = "Three" });
            grid.Children.Add(Tab);
*/
        }

        private void Run_MouseEnter(object sender, MouseEventArgs e)
        {
            link.IsOpen = true;
        }

        private void Run_MouseLeave(object sender, MouseEventArgs e)
        {
            link.IsOpen = false;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start((sender as Hyperlink).NavigateUri.ToString()); //получим строку с сылкой гугл
        }
    }
}
