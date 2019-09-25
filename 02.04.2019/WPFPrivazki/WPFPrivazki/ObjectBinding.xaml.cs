using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFPrivazki
{
    /// <summary>
    /// Interaction logic for ObjectBinding.xaml
    /// </summary>
    public partial class ObjectBinding : Window
    {
        public ObservableCollection <Student> Students { get; set; }
        Student _student;
        public ObjectBinding()
        {
            InitializeComponent();
            Students = new ObservableCollection <Student>
            {
                new Student{FirstName="Tom", LastName="Djerade",Age=23},
                new Student{FirstName="Ralf", LastName="Lauren",Age=54}
            };
        }

        private void dgStudents_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                //это тот элемент который сейчас выделен, активный 
                _student = dgStudents.SelectedItem as Student;
            }
            catch
            {

            }
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            if(_student!=null)
            {
                _student.Age++;
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Students.Add(new Student {FirstName = "John", LastName = "Doe", Age = 30 });

        }
    }
}
