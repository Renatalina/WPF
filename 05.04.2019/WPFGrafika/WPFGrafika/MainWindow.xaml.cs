using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WPFGrafika
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            for(double angle=10.0; ;angle+=5.0)
            {
                //rect.RenderTransform = new RotateTransform(angle);
            }
        }
        /*
private DrawingVisual rectVisual = new DrawingVisual();
private const int NumberOfVisualItems = 1;

public MainWindow()
{
   InitializeComponent();
   CreateRectVisual();// Вспомогательная функция для создания прямоугольника 
}
private void CreateRectVisual()
{
   using (DrawingContext drawCtx = rectVisual.RenderOpen())
   {

       // Верхняя, левая, нижняя и правая позиции прямоугольника 
       Rect rect = new Rect(50, 50, 105, 55);
       drawCtx.DrawRectangle(Brushes.AliceBlue, 
           new Pen(Brushes.Blue, 5), rect);
       drawCtx.DrawText(
           //это мы дописываем текс в прямоугольлник
           new FormattedText( "Hello",
           //это язык текста, а для руского писать "ru-ru"
           CultureInfo.GetCultureInfo("en-us"),
           //выравнивание по левому краю
           FlowDirection.LeftToRight,
           //тип шрифта вердана
           new Typeface("Verdana"),
           //размер шрифта
           32,
           //цвет нашего текста
           Brushes.Tomato), 
           //координаты нашего текста
           new Point(60, 60));
   }

   // Зарегистрируем наш визуальный элемент в дереве объектов, чтобы 
   // гарантировать поддержку маршрутизируемых событий, проверку попадания и 
   //у класса вижуал специальные, это все класс вижуал 
   AddVisualChild(rectVisual);
   AddLogicalChild(rectVisual);
}

// Необходимые переопределения. Графическая система WPF вызовет 
// это для определения того, сколько элементов надо визуализировать, 
//и что именно в них визуализировать. 
protected override int VisualChildrenCount
{
   get { return NumberOfVisualItems; }
}

protected override Visual GetVisualChild(int index)
{
   // Нумерация элементов в коллекции начинается с нуля, поэтому вычитаем 1. 
   if (index != (NumberOfVisualItems - 1))
       throw new ArgumentOutOfRangeException("index", 
           "Don't have that visual!");
   return rectVisual;
}
*/

    }
}
