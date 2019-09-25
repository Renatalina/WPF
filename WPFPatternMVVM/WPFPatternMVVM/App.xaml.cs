using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFPatternMVVM.Models;
using WPFPatternMVVM.Views;

namespace WPFPatternMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            List<StudentModel> students = new List<StudentModel>
            {
                new StudentModel{FirstName="Jack", LastName="Daniels",
                    BirthDate =new DateTime(1997,7,23)},
                new StudentModel{FirstName="Jeam", LastName="Beam",
                    BirthDate =new DateTime(1998,11,2)},
                new StudentModel{FirstName="John", LastName="Doe",
                    BirthDate =new DateTime(1999,5,12)}
            };
            MainView mainView = new MainView
            {
                DataContext = new MainViewModel(students)
            };
            mainView.Show();
        }
    }
}
