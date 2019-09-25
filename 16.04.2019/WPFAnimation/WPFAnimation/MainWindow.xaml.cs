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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPFAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long _start;
        double _duration = 5000;
        double _from = 9.0;
        double _to = 18.0;

        public MainWindow()
        {
            InitializeComponent();


            
              //здесь мы руками все прописываем
            //DispatcherTimer timer = new DispatcherTimer
            //{
            //    Interval = TimeSpan.FromMilliseconds(50)

            //};
            //timer.Tick += Timer_Tick;
            //_start = Environment.TickCount;
            //timer.IsEnabled = true;
            
        }

      /*
        
private bool _isCompleted=false;

private void button1_MouseEnter(object sender, MouseEventArgs e)
{
   if (!_isCompleted)
   {
       //опять запускаем событие на анимацию
       //после наведения мышки на объект
       _isCompleted = true;
       DoubleAnimation animation = new DoubleAnimation
       {
           Duration=new Duration(TimeSpan.FromSeconds(3)),
           From=0,
           To=360,
          // RepeatBehavior=RepeatBehavior.Forever
          //RepeatBehavior=new RepeatBehavior(3)
          RepeatBehavior=new RepeatBehavior(TimeSpan.FromSeconds(10))
       };
       animation.Completed += Animation_Completed;
       RotateTransform rotate = new RotateTransform();
       button1.RenderTransformOrigin = new Point(0.5, 0.5);
       button1.RenderTransform = rotate;

       rotate.BeginAnimation(RotateTransform.AngleProperty, animation);

   }
}

private void Animation_Completed(object sender, EventArgs e)
{
   _isCompleted = false;
}

private void button1_Click(object sender, RoutedEventArgs e)
{
   DoubleAnimation animation = new DoubleAnimation
   {
       From = 1.0,
       To = 0,
       AutoReverse=true
   };
   button1.BeginAnimation(Button.OpacityProperty, animation);

}*/
        
            /*
private void Timer_Tick(object sender, EventArgs e)
{
long elapsed = Environment.TickCount - _start;
if(elapsed>=_duration)
{
button1.FontSize = _to;
(sender as DispatcherTimer).IsEnabled = false;
return;
}
double increase = _to - _from;
button1.FontSize = _from + (increase / (_duration / elapsed));
}*/
    }
}
