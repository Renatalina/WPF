using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFPatternMVVM.Commands;
using WPFPatternMVVM.Models;

namespace WPFPatternMVVM.ViewModels
{
    class AddStudentViewModel: BaseViewModel
    {
        private Action<StudentModel> _refreshStudents;

        private StudentModel _currentStudent;

        public StudentModel CurrentStudent
        {
            get { return _currentStudent; }
            set
            {
                _currentStudent = value;
                OnPropertyChanged(nameof(CurrentStudent)); // "CurrentStudent"
            }
        }
        public AddStudentViewModel(Action<StudentModel> action)
        {
            _refreshStudents += action;

            CurrentStudent = new StudentModel { BirthDate = DateTime.Now.Date };
        }

        ICommand _cancelCommand;

        public ICommand CancelCommand
        {
            get
            {
                return _cancelCommand ?? (_cancelCommand = new BaseCommand(arg => OnCancelStudent()));
            }
        }

        private void OnCancelStudent()
        {
            // ------------------- 1 ---------------------
            //Application.Current.Windows[1].Close();

            // ------------------- 2 ---------------------
            //Window window = Application.Current.Windows.Cast<Window>().FirstOrDefault(w => w.Name == "AddView");
            //if (window!=null)
            //{
            //    window.Close();
            //}

            Application.Current.Windows.Cast<Window>().FirstOrDefault(w => w.Name == "AddView")?.Close();
        }

        ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand ?? (_saveCommand = new BaseCommand(arg => OnSaveStudent()));
            }
        }

        private void OnSaveStudent()
        {
            try
            {
                _refreshStudents(CurrentStudent);

                OnCancelStudent();
            }
            catch
            {
                throw;
            }
        }
    }
}
