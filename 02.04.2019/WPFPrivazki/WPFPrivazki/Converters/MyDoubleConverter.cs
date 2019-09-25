using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFPrivazki.Converters
{
    class MyDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, 
            object parameter, CultureInfo culture)
        {
            //double val = (double)value;
            //return (int)val;
            //ли так можно 
            //это мы преобразовали то что пришло в дабл 
            return System.Convert.ToInt32(value);

        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
