using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFPatternMVVM.Commands
{
    class MinimizeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //вот именно эта команда, свернет окно
            //к этому методу мы обратимся из Сommand в другом месте
            //добавим баттону это свойство которого у него нет
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
            
        }
    }
}
