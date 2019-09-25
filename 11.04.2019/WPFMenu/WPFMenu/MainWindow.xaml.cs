using System;
using System.Collections.Generic;
using System.IO;
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

using SWF= System.Windows.Forms;
//сделали псевдоним для пронстранства имен System.Windows.Forms

namespace WPFMenu
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

        //System.Windows.Forms.OpenFileDialog _openFileDialog;
      SWF.OpenFileDialog _openFileDialog;
        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if(_openFileDialog==null)
            {
                _openFileDialog = new SWF.OpenFileDialog
                {
                    Filter = "txt files(*.txt)|*.txt"
                };
            }
            if(_openFileDialog.ShowDialog()==SWF.DialogResult.OK)
            {
                textBox.Text = File.ReadAllText(_openFileDialog.FileName,
                    Encoding.GetEncoding(1251));
                textBox.CaretIndex = textBox.Text.Length;
                textBox.Focus();
            }
        }
        private bool _isDirty;

        SWF.SaveFileDialog _saveFileDialog; 

        private void SaveCommand_Execuden(object sender, ExecutedRoutedEventArgs e)
        {
            _saveFileDialog = new SWF.SaveFileDialog();
            _saveFileDialog.ShowDialog();
        }

        private void SaveCommand_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = _isDirty;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox.Text))
            {
                _isDirty = true;
            }
            else
            {
                _isDirty = true;
            }
        }
    }
}
