using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFPatternMVVM.Commands;
using WPFPatternMVVM.ViewModels;
using WPFPatternMVVM.Views;

namespace WPFPatternMVVM.Models
{
    class MainViewModel:BaseViewModel
    {
        public ObservableCollection<StudentModel> StudentsCollection { get; set; }

        public MainViewModel(List<StudentModel> students)
        {
            StudentsCollection = new ObservableCollection<StudentModel>(students);
        }
        //здесь будем сворачивать наше окно
        ICommand _minimizeCommand;

        public ICommand MinimizeCommand {
            get
            {
                //ленивая загрузка
                //что бы объект создавался по необходимости 
                
                    if(_minimizeCommand ==null)
                {
                    //здесь мы инициализируем ссылку миним...
                    //BaseCommand это конструктор
                    //arg это специальный метод его нет, поэтому он подчеркнул OnMinimmizeWindow
                    //
                    _minimizeCommand = new MinimizeCommand();
                }
                return _minimizeCommand;
            }
            
        }

        private void OnMinimmizeWindow()
        {
            throw new NotImplementedException();
        }

        //тоже самое что и ICommand _minimizeCommand; 
        //только здесь мы не свовариваем окно, а добавляем пользователя
        ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new BaseCommand(arg => OnAddStudent()));
            }
        }

        private void OnAddStudent()
        {
            //StudentsCollection.Add(
            //    new StudentModel
            //    {
            //        FirstName = "Jack",
            //        LastName = "Sparrow",
            //        BirthDate = new DateTime(1678, 5, 23)
            //    }); 

            AddStudentView addStudent = new AddStudentView
            {
                DataContext = new AddStudentViewModel( AddStudentInCollection)
            };
            addStudent.ShowDialog();

        }

        private void AddStudentInCollection(StudentModel obj)
        {
            StudentsCollection.Add(obj);
        }
    }
}
