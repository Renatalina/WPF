using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WPFPrivazki.Converters
{
    class MyColorConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            byte colorA = Convert.ToByte(value);
            Color color = new Color
            {
                A = 255,
                G = Convert.ToByte(colorA + 155)
            };
            return new SolidColorBrush(color);
        }

        object IValueConverter.ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
