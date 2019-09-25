using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPFAnimation2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //[System.Runtime.InteropServices.DllImport("gdi32.dll")]
        //public static extern bool DeleteObject(IntPtr hObject);

        //Bitmap _bitmap;
        //BitmapSource _source;

        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    _source = GetSource();
        //    flagImage.Source = _source;
        //    ImageAnimator.Animate(_bitmap, OnFrameChanged);
        //}


        //private BitmapSource GetSource()
        //{
        //    try
        //    {
        //        if (_bitmap == null)
        //        {
        //            _bitmap = new Bitmap(Application.GetResourceStream(new Uri("flag.gif", UriKind.Relative)).Stream);
        //        }
        //        IntPtr handle = IntPtr.Zero;
        //        handle = _bitmap.GetHbitmap();

        //        BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());

        //        // надо удалить дескриптор точечного рисунка, который создает функция Bitmap.GetHbitmap иначе память, занятая им, не освободится
        //        DeleteObject(handle);

        //        return bitmapSource;
        //    }
        //    catch { }
        //    return _source;
        //}

        //private void OnFrameChanged(object sender, EventArgs e)
        //{
        //    Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(FrameUpdatedCallback));
        //}

        //private void FrameUpdatedCallback()
        //{
        //    ImageAnimator.UpdateFrames();
        //    if (_source == null)
        //    {
        //        _source.Freeze();
        //    }
        //    _source = GetSource();
        //    flagImage.Source = _source;
        //    InvalidateVisual();
        //}

    }
}
